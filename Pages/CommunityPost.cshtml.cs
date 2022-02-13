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
    public class CommunityPostModel : PageModel
    {
        [BindProperty]
        public List<CommunityPost> allCommunityPosts { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private CommunityPostService _svc;
        public CommunityPostModel(ILogger<IndexModel> logger, CommunityPostService service)
        {
            _logger = logger;
            _svc = service;
        }
        public void OnGet()
        {
            allCommunityPosts = _svc.GetAllCommunityPosts();
        }
    }
}
