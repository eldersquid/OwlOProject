using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class CommunityPostEditModel : PageModel
    {
        [BindProperty]
        public CommunityPost MyCommunityPost { get; set; }
        private readonly Services.CommunityPostService _svc;
        public CommunityPostEditModel(Services.CommunityPostService service)
        {
            _svc = service;
        }
        public void OnGet(string id)
        {
            MyCommunityPost = _svc.GetCommunityPostById(id);
        }
        public IActionResult OnPost()
        {
            _svc.UpdateCommunityPost(MyCommunityPost);
            return Redirect("Community");
        }
    }
}
