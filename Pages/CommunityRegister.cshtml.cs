using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class CommunityRegisterModel : PageModel
    {

        [BindProperty]
        public Community MyCommunity { get; set; }
        private readonly Services.CommunityService _svc;
        public CommunityRegisterModel(Services.CommunityService service)
        {
            _svc = service;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            
            if (_svc.AddCommunity(MyCommunity))
            {
                return RedirectToPage("Community");
            }
            else
            {

                return Page();
            }
        }
    }
}
