using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OwlOProjectA.Areas.Identity.Data;
using OwlOProjectA.Models;
using OwlOProjectA.Services;


namespace OwlOProjectA.Pages
{
    public class OwlShopModel : PageModel
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;



        [BindProperty]
        public List<Voucher> allVouchers { get; set; }

        [BindProperty]
        public List<LuckyDraw> allLuckyDraws { get; set; }

        [BindProperty]
        public ApplicationUser currentUser { get; set; }

        private readonly ILogger<OwlShopModel> _logger;
        private VoucherService _svc;
        private LuckyDrawService _svc2;
        public OwlShopModel(ILogger<OwlShopModel> logger, VoucherService service, IEmailSender emailSender, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, LuckyDrawService service2)
        {
            _logger = logger;
            _svc = service;
            _svc2 = service2;
            _userManager = userManager;
            _signInManager = signInManager;
            
            _emailSender = emailSender;
        }
        public void OnGet()
        {
            currentUser = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
            allVouchers = _svc.GetAllVouchers();
            allLuckyDraws = _svc2.GetAllLuckyDraws();
            
           
        }
    }
}
