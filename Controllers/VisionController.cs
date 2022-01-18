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



namespace OwlOProjectA.Controllers
{
    public class VisionController : Controller
    {


        [HttpPost]
        public string capture(string fileName)
        {
            string credential_path = @"./credentials/owlprojectchatbot.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);

            string image_path = @"./wwwroot/Documents/" + fileName;
            string fileExtension = fileName[fileName.IndexOf(".")..];
            Console.WriteLine(fileExtension);

            Console.WriteLine(image_path);


            //switch (fileExtension)
            //{
            //    case ".png" :
            //        break;
            //    case ".jpg":
            //        break;
            //    case ".doc":
            //        break;
            //    case ".docx":
            //        break;
            //    case ".pdf":
            //        break;

            //}

            string text = "NAME YU JIMIN DATE OF BIRTH 12-05-2000 HOUGANG AVE 9";
            var client = LanguageServiceClient.Create();
            var response = client.AnalyzeEntities(Document.FromPlainText(text));
            
            Console.WriteLine(response);
            foreach (var entity in response.Entities)
            {
                Console.WriteLine($"Entity: \"{entity.Name}\" ({entity.Type})");
                Console.WriteLine(entity.Metadata);
                
            }








            //var image = Image.FromFile(image_path);
            //ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            //TextAnnotation text = client.DetectDocumentText(image);
            //Console.WriteLine($"Text: {text.Text}");
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
            //return text.Text;
            return "YES";



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
