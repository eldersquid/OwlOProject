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
    public class CommunityModel : PageModel
    {
        [BindProperty]
        public List<Community> allCommunities { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private CommunityService _svc;
        public CommunityModel(ILogger<IndexModel> logger, CommunityService service)
        {
            _logger = logger;
            _svc = service;
        }
        public void OnGet()
        {
            allCommunities = _svc.GetAllCommunities();
        }
    }
}
