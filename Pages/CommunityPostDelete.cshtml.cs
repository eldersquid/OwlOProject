using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class CommunityPostDeleteModel : PageModel
    {
        private readonly Services.CommunityPostService _svc;
        public CommunityPostDeleteModel(Services.CommunityPostService service)
        {
            _svc = service;
        }

        [BindProperty]
        public CommunityPost MyCommunityPost { get; set; }
        public IActionResult OnGet(string id)
        {

            MyCommunityPost = _svc.GetCommunityPostById(id);
            if (MyCommunityPost == null)
            {
                return RedirectToPage("Error");
            }
            else
            {
                _svc.DeleteCommunityPost(MyCommunityPost);
                return RedirectToPage("CommunityPost");
            }
        }
    }
}
