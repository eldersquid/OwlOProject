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
    public class VoucherEditModel : PageModel
    {

        [BindProperty]
        public Voucher voucher { get; set; }
        private readonly Services.VoucherService _svc;
        private readonly ILogger<VoucherEditModel> _logger;
        public VoucherEditModel(ILogger<VoucherEditModel> logger,Services.VoucherService service)
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
            voucher = _svc.GetVoucherByID(id);
            if (voucher == null)
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
            if (_svc.UpdateVoucher(voucher) == true)
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
