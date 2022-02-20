using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Dialogflow.V2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace OwlOProjectA.Pages.Danish
{
    public class ViewIntentsModel : PageModel
    {
        [BindProperty]
        public List<Intent> allIntents { get; set; }

        private readonly Controllers.IntentController _con;

      

        public ViewIntentsModel(Controllers.IntentController intent)
        {
            
            _con = intent;
        }
        public void OnGet()
        {
            allIntents = _con.ViewIntents();
            
            
           
        }

       

    }
}
