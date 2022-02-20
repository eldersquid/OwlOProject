using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Dialogflow.V2;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OwlOProjectA.Areas.Identity.Data;
using OwlOProjectA.Models;
using OwlOProjectA.Services;

namespace OwlOProjectA.Pages.Danish
{
    public class VouchersOwnedModel : PageModel
    {
        [BindProperty]
        public List<VoucherDistribution> allVouchersOwned { get; set; }

        [BindProperty]
        public List<Voucher> allVouchers { get; set; }


        private readonly UserManager<ApplicationUser> _userManager;
        private readonly Controllers.IntentController _con;

        private VoucherDistributionService _svc;
        private VoucherService _svc2;

       
        public VouchersOwnedModel(VoucherService service2, VoucherDistributionService service, UserManager<ApplicationUser> userManager)
        {
            
            _svc = service;
            _svc2 = service2;
            _userManager = userManager;
        }
        public void OnGet(string email)
        {
            System.Diagnostics.Debug.WriteLine("TESTTESTTESTTEST");
            var user_email = _userManager.GetUserAsync(User).GetAwaiter().GetResult().Email;
            allVouchersOwned = _svc.GetAllVoucherDistributionsByEmail(user_email);
            foreach(var voucher in allVouchersOwned)
            {
                System.Diagnostics.Debug.WriteLine("Voucher is : " + voucher);
            }
            

        }

       

    }
}
