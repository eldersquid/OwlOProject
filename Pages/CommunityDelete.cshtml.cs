using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class CommunityDeleteModel : PageModel
    {
        private readonly Services.CommunityService _svc;
        public CommunityDeleteModel(Services.CommunityService service)
        {
            _svc = service;
        }

        [BindProperty]
        public Community MyCommunity { get; set; }
        public IActionResult OnGet(string id)
        {

            MyCommunity = _svc.GetCommunityById(id);
            if (MyCommunity == null)
            {
                return RedirectToPage("Error");
            }
            else
            {
                _svc.DeleteCommunity(MyCommunity);
                return RedirectToPage("AdminCommunity");
            }
        }
    }
}
