using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Areas.Identity.Data;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages.Danish
{
    public class VoucherPurchaseModel : PageModel
    {
        private readonly Services.VoucherDistributionService _svc2;
        private readonly Services.VoucherService _svc;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public VoucherPurchaseModel(Services.VoucherService service, Services.VoucherDistributionService service2, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _svc = service;
            _svc2 = service2;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [BindProperty]
        public Voucher voucher { get; set; }


        [BindProperty]
        public ApplicationUser currentUser { get; set; }
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
                Double voucher_price = 0;
                if (voucher.Super_Deal == true)
                {
                    voucher_price = voucher.Voucher_Cost * ((100 - voucher.DiscountDeal_Percentage) / 100);
                }
                else
                {
                    voucher_price = voucher.Voucher_Cost;
                }

                var voucherDistribution = new VoucherDistribution();
                currentUser = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
                if (currentUser.Owl_Points >= voucher_price)
                {
                    voucherDistribution.VoucherDistribution_ID = Guid.NewGuid().ToString();
                    voucherDistribution.VoucherDistribution_OwnerEmail = currentUser.Email;
                    voucherDistribution.VoucherDistribution_VoucherID = voucher.Vouchers_ID;
                    voucherDistribution.VoucherDistribution_VoucherCompany = voucher.Voucher_Company;
                    voucherDistribution.VoucherDistribution_VoucherExpiry = voucher.Voucher_Expiry;
                    voucherDistribution.VoucherDistribution_VoucherSuperDeal = voucher.Super_Deal;
                    voucherDistribution.VoucherDistribution_VoucherName = voucher.Voucher_Name;
                    voucherDistribution.VoucherDistribution_VoucherCost = voucher.Voucher_Cost;
                    currentUser.Owl_Points = Convert.ToInt32(Convert.ToDouble(currentUser.Owl_Points) - voucher_price);
                    _userManager.UpdateAsync(currentUser).GetAwaiter().GetResult();
                    _svc2.AddVoucherDistribution(voucherDistribution);
                    return RedirectToPage("VouchersOwned");
                }
                else
                {
                    return RedirectToPage("OwlShop");
                }
                
            }
        }
    }
}
