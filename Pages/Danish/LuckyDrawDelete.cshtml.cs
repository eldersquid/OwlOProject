using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class LuckyDrawDeleteModel : PageModel
    {
        private readonly Services.LuckyDrawService _svc;
        public LuckyDrawDeleteModel(Services.LuckyDrawService service)
        {
            _svc = service;
        }

        [BindProperty]
        public LuckyDraw voucher { get; set; }
        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return RedirectToPage("Error");
            }

            voucher = _svc.GetLuckyDrawByID(id);
            if (voucher == null)
            {
                return RedirectToPage("Error");
            }
            else
            {
                _svc.DeleteLuckyDraw(voucher);
                return RedirectToPage("OwlShop");
            }
        }
    }
}
