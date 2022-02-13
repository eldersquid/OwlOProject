using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages.Danish
{
    public class FAQArticleModel : PageModel
    {
        [BindProperty]
        public FAQ FAQ { get; set; }
        private readonly Services.FAQService _svc;
        private readonly ILogger<FAQArticleModel> _logger;
        public FAQArticleModel(ILogger<FAQArticleModel> logger, Services.FAQService service)
        {
            _svc = service;
            _logger = logger;
        }
        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return NotFound();

            }
            FAQ = _svc.GetFAQByID(id);
            if (FAQ == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
