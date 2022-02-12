using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Dialogflow.V2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class IntentDeleteModel : PageModel
    {
        private readonly Controllers.IntentController _con;



        public IntentDeleteModel(Controllers.IntentController intent)
        {

            _con = intent;
        }

        [BindProperty]
        public Intent intent { get; set; }
        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return RedirectToPage("Error");
            }
            else
            {
                _con.DeleteIntent(id);
                return RedirectToPage("ViewIntents");
            }
        }
    }
}
