using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class CommunityEditModel : PageModel
    {
        [BindProperty]
        public Community MyCommunity { get; set; }
        private readonly Services.CommunityService _svc;
        public CommunityEditModel(Services.CommunityService service)
        {
            _svc = service;
        }
        public void OnGet(string id)
        {
            MyCommunity = _svc.GetCommunityById(id);
        }
        public IActionResult OnPost()
        {
            _svc.UpdateCommunity(MyCommunity);
            return Redirect("Community");
        }
    }
}
