using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class ComPostCreateModel : PageModel
    {
        [BindProperty]
        public CommunityPost MyCommunityPost { get; set; }
        private readonly Services.CommunityPostService _svc;
        public ComPostCreateModel(Services.CommunityPostService service)
        {
            _svc = service;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            if (_svc.AddCommunityPost(MyCommunityPost))
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
