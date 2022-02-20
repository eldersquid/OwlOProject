using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OwlOProjectA.Models;
using OwlOProjectA.Services;

namespace OwlOProjectA.Pages
{
    public class CommentsModel : PageModel
    {
        [BindProperty]
        public List<Comment> allComments { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private CommentService _svc;
        public CommentsModel(ILogger<IndexModel> logger, CommentService service)
        {
            _logger = logger;
            _svc = service;
        }
        public void OnGet()
        {
            allComments = _svc.GetAllComments();
        }
    }
}
