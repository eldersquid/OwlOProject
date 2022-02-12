using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class VoucherCreateModel : PageModel
    {

        [BindProperty]
        public Voucher voucher { get; set; }

        private readonly Services.VoucherService _svc;
        public VoucherCreateModel(Services.VoucherService service)
        {
            _svc = service;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            voucher.Vouchers_ID = Guid.NewGuid().ToString();
            
            if (_svc.AddVoucher(voucher))
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
