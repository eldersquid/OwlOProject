using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class LuckyDrawEditModel : PageModel
    {

        [BindProperty]
        public LuckyDraw luckydraw { get; set; }
        private readonly Services.LuckyDrawService _svc;
        private readonly ILogger<LuckyDrawEditModel> _logger;
        public LuckyDrawEditModel(ILogger<LuckyDrawEditModel> logger, Services.LuckyDrawService service)
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
            luckydraw = _svc.GetLuckyDrawByID(id);
            if (luckydraw == null)
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
            if (_svc.UpdateLuckyDraw(luckydraw) == true)
            {
                return RedirectToPage("./OwlShop");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
