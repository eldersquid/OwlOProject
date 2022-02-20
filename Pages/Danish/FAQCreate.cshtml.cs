using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Areas.Identity.Data;
using OwlOProjectA.Models;

namespace OwlOProjectA.Pages
{
    public class FAQCreateModel : PageModel
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;

        [BindProperty]
        public FAQ FAQ { get; set; }

        [BindProperty]
        public ApplicationUser currentUser { get; set; }

        private readonly Services.FAQService _svc;
        public FAQCreateModel(Services.FAQService service, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _svc = service;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            currentUser = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
            FAQ.FAQ_ID = Guid.NewGuid().ToString();
            FAQ.FAQ_DatePublished = DateTime.Now;
            FAQ.FAQ_Author = currentUser.Name;
            
            if (_svc.AddFAQ(FAQ))
            {
                
                return RedirectToPage("FAQHome");
            }
            else
            {
                
                return Page();
            }
        }
    }
}
