using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class LuckyDrawCreateModel : PageModel
    {

        [BindProperty]
        public LuckyDraw luckydraw { get; set; }

        private readonly Services.LuckyDrawService _svc;
        public LuckyDrawCreateModel(Services.LuckyDrawService service)
        {
            _svc = service;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            luckydraw.LuckyDraw_ID = Guid.NewGuid().ToString();
            luckydraw.LuckyDraw_OriginalQuantity = luckydraw.LuckyDraw_Quantity;
            if (_svc.AddLuckyDraw(luckydraw))
            {
                
                return RedirectToPage("OwlShop");
            }
            else
            {
                
                return Page();
            }
        }
    }
}
