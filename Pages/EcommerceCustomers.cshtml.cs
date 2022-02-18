using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Web.Pages
{
    public class EcommerceCustomersModel : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("ecommerce-customers")]
        public ActionResult ecommercecustomers()
        {
            return View();
        }

    }
}