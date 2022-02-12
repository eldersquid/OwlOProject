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
    public class OwlShopModel : PageModel
    {

        [BindProperty]
        public List<Voucher> allVouchers { get; set; }

        private readonly ILogger<OwlShopModel> _logger;
        private VoucherService _svc;
        public OwlShopModel(ILogger<OwlShopModel> logger, VoucherService service)
        {
            _logger = logger;
            _svc = service;
        }
        public void OnGet()
        {
            allVouchers = _svc.GetAllVouchers();

        }
    }
}
