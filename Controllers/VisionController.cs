using Google.Cloud.Vision.V1;
using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Google.Cloud.Language.V1;
using System.Text.RegularExpressions;
using Google.Protobuf;

namespace OwlOProjectA.Controllers
{
    public class VisionController : Controller
    {
        public class Details
        {
            public string NRIC { get; set; }
            public string Gender { get; set; }
            public string Name { get; set; }
            public string Address { get; set;  }
            public string DOB { get; set; }
            public string Citizenship { get; set; }
            public string Email { get; set; }

        }

        [HttpPost]
        public JsonResult capture(string fileName)
        {
           
            var details = new Details();
            string credential_path = @"./credentials/owlprojectchatbot.json";
            System.Environment.SetEnvironmentVariable("google_application_credentials", credential_path);
            Regex NRIC = new Regex(@"^[STFG]\d{7}[A-Z]$");
            Regex Email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            string image_path = @"./wwwroot/Documents/" + fileName;
            string fileExtension = fileName[fileName.IndexOf(".")..];
            Console.WriteLine(fileExtension);

            Console.WriteLine(image_path);


            //var text = "ABOUT ME\nDate of Birth: November 1, 1997\nAge: 23\n\nGender: Male\nBirth Place: Hougang\nCONTACT\nBlk 999B Buangkok Crescent,\n#10-757 S (532999)\n9114 6919\nmdanish.ashari@gmail.com\nS9738512B";





            var text = "";
            var image = Image.FromFile(image_path);
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            if (fileExtension.ToLower() == ".png" || fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".jpeg")
            {
                TextAnnotation image_text = client.DetectDocumentText(image);
                text = image_text.Text;
                Console.WriteLine($"Text: {text}");
            }
            else
            {
                Byte[] bytes = System.IO.File.ReadAllBytes(image_path);
                var content_byte = ByteString.CopyFrom(bytes);
                var syncRequest = new AnnotateFileRequest
                {
                    InputConfig = new InputConfig
                    {
                        Content = content_byte,
                        MimeType = "application/pdf"
                    }
                };
                syncRequest.Features.Add(new Feature
                {
                    Type = Feature.Types.Type.DocumentTextDetection
                });

                List<AnnotateFileRequest> requests =
                    new List<AnnotateFileRequest>();
                requests.Add(syncRequest);

                var document_text = client.BatchAnnotateFiles(requests);
                Console.WriteLine(document_text.Responses[0].Responses[0].FullTextAnnotation.Text);
                text = document_text.Responses[0].Responses[0].FullTextAnnotation.Text;
            }







            //foreach (var page in text.Pages)
            //{
            //    foreach (var block in page.Blocks)
            //    {
            //        string box = string.Join(" - ", block.BoundingBox.Vertices.Select(v => $"({v.X}, {v.Y})"));
            //        Console.WriteLine($"Block {block.BlockType} at {box}");
            //        foreach (var paragraph in block.Paragraphs)
            //        {
            //            box = string.Join(" - ", paragraph.BoundingBox.Vertices.Select(v => $"({v.X}, {v.Y})"));
            //            Console.WriteLine($"  Paragraph at {box}");
            //            foreach (var word in paragraph.Words)
            //            {
            //                Console.WriteLine($"    Word: {string.Join("", word.Symbols.Select(s => s.Text))}");
            //            }
            //        }
            //    }
            //}


            var nlp_client = LanguageServiceClient.Create();
            var response = nlp_client.AnalyzeEntities(Document.FromPlainText(text));

            Console.WriteLine(response);
            Double address_salience = 0;
            Double date_salience = 0;
            Double person_salience = 0;
            foreach (var entity in response.Entities)
            {
                Console.WriteLine($"Entity: \"{entity.Name}\" ({entity.Type})");
                Console.WriteLine(entity.Metadata);
                switch (entity.Type.ToString())
                {
                    case "Address":
                        if (entity.Metadata.ContainsKey("country") || entity.Metadata.ContainsKey("locality"))
                        
                        {
                            if (address_salience <= Convert.ToDouble(entity.Salience))
                            {
                                details.Address = entity.Metadata["street_name"] + " " + entity.Metadata["street_number"];
                                address_salience = Convert.ToDouble(entity.Salience);
                            }
                        }
                        
                        break;
                    case "Date":
                        if (date_salience <= Convert.ToDouble(entity.Salience))
                        {
                            details.DOB = entity.Name;
                            date_salience = Convert.ToDouble(entity.Salience);
                        }
                        break;
                    case "Person":
                        if (person_salience <= Convert.ToDouble(entity.Salience))
                        {
                            details.Name = entity.Name;
                            person_salience = Convert.ToDouble(entity.Salience);
                        }
                        break;
                }


            }

            //return text.Text;
            string[] words = text.Split("\n");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Array Number : {i} Array : {words[i]}");
                if (words[i].Contains("Male"))
                {
                    details.Gender = "M";
                }
                else if (words[i].Contains("Female"))
                {
                    details.Gender = "F";
                }
                if (Email.Match(words[i]).Success)
                {
                    details.Email = words[i];
                }
                if (NRIC.Match(words[i]).Success)
                {
                    details.NRIC = words[i];
                }

            }
            Console.WriteLine($"Gender: {details.Gender}");
            Console.WriteLine($"Email: {details.Email}");
            Console.WriteLine($"NRIC: {details.NRIC}");
            Console.WriteLine($"Name: {details.Name}");
            Console.WriteLine($"Address: {details.Address}");
            return Json(details);

        }
        
        [HttpPost]
        public string upload(IFormFile file)
        {
            string filename = "";
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Documents/");
            Console.WriteLine("This is the : " + file);
                if (file!=null)
                {
                    filename = Guid.NewGuid().ToString() + "___" + Path.GetExtension(file.FileName);
                    string filepath = Path.Combine(directory, filename);
                    using (var stream = new FileStream(filepath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }

            return filename;

        }

    }
}
