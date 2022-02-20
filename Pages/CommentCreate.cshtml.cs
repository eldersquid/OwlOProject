using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class CommentCreateModel : PageModel
    {
        [BindProperty]
        public Comment MyComment { get; set; }
        private readonly Services.CommentService _svc;
        public CommentCreateModel(Services.CommentService service)
        {
            _svc = service;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            if (_svc.AddComment(MyComment))
            {
                return RedirectToPage("CommunityPost");
            }
            else
            {

                return Page();
            }
        }
    }
}
