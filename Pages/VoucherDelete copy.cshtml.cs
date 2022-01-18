using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class VoucherDeleteCopyModel : PageModel
    {
        private readonly Services.VoucherService _svc;
        public VoucherDeleteCopyModel(Services.VoucherService service)
        {
            _svc = service;
        }

        [BindProperty]
        public Voucher voucher { get; set; }
        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return RedirectToPage("Error");
            }

            voucher = _svc.GetVoucherByID(id);
            if (voucher == null)
            {
                return RedirectToPage("Error");
            }
            else
            {
                _svc.DeleteVoucher(voucher);
                return RedirectToPage("OwlShop");
            }
        }
    }
}
