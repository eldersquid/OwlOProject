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
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<Owlee> allOwlees { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private OwleeService _svc;

        public IndexModel(ILogger<IndexModel> logger, OwleeService service)
        {
            _logger = logger;
            _svc = service;
        }

        public void OnGet()
        {
            allOwlees = _svc.GetAllOwlees();
            
        }
        public void OnPost()
        {

        }
    }
}
