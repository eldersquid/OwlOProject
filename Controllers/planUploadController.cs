using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Controllers
{
    public class planUploadController : Controller
    {
        [HttpPost]
        public string upload(IFormFile file)
        {
            Console.WriteLine(file);
            string filename = "";
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PlanImages/");
            Console.WriteLine("This is the : " + file);
            if (file != null)
            {
                filename = Guid.NewGuid().ToString() + "_" + Path.GetExtension(file.FileName);
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
