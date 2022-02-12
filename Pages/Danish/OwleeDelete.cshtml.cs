using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class OwleeDeleteModel : PageModel
    {
        private readonly Services.OwleeService _svc;
        public OwleeDeleteModel(Services.OwleeService service)
        {
            _svc = service;
        }

        [BindProperty]
        public Owlee MyOwlee { get; set; }
        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return RedirectToPage("Error");
            }

            MyOwlee = _svc.GetOwleeByEmail(id);
            if (MyOwlee == null)
            {
                return RedirectToPage("Error");
            }
            else
            {
                _svc.DeleteOwlee(MyOwlee);
                return RedirectToPage("Index");
            }
        }
    }
}
