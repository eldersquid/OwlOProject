using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OwlOProjectA.Models;
using OwlOProjectA.Services;

namespace OwlOProjectA.Pages.Danish
{
    public class FAQHomeModel : PageModel
    {
        [BindProperty]
        public List<FAQ> allFAQs { get; set; }

        private readonly ILogger<FAQHomeModel> _logger;
        private FAQService _svc;

        public FAQHomeModel(ILogger<FAQHomeModel> logger, FAQService service)
        {
            _logger = logger;
            _svc = service;
        }


        public void OnGet()
        {
            allFAQs = _svc.GetAllFAQs();
        }
    }
}
