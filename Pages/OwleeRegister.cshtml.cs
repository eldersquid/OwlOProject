using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IronOcr;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class OwleeRegisterModel : PageModel
    {
        

        [BindProperty]
        public Owlee MyOwlee { get; set; }

        private readonly Services.OwleeService _svc;
        public OwleeRegisterModel(Services.OwleeService service)
        {
            _svc = service;
        }
        public void OnGet()
        {
            
        }

      



        public IActionResult OnPost()
        {
            MyOwlee.Owl_Points = 0;
            MyOwlee.Inventory_ID = Guid.NewGuid().ToString();
            if (_svc.AddOwlee(MyOwlee))
            {
                return RedirectToPage("Index");
            }
            else
            {
                
                return Page();
            }
        }
    }
}
