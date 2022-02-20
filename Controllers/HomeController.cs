using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using System.Globalization;
using CsvHelper;


namespace OwlOProjectA.Controllers
{
    
    public class HomeController : Controller
    {
        
        public string scanDoc()
        {

            return "YEES";
        }

        public string scanItem()
        {

            return "YEES";
        }

        public void readCSV(string csvFile)
        {
            try
            {
                using (var reader = new StreamReader(csvFile))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<dynamic>().ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        

        
        


    }
}
