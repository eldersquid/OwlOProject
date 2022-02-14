using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace owlo_plan.Pages
{
    public class ExploreProjectCategoriesModel : PageModel
    {
        [BindProperty]
        public string[] availableCause { get; set; }

        public void OnGet()
        {
            string[] arraylol = { "Elderly", "Special needs", "Mental health", "Homelessness", "Animal", "Children"};
            availableCause = arraylol;

        }
    }
}
