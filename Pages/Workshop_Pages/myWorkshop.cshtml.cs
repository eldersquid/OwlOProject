using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OwlOProjectA.Areas.Identity.Data;
using OwlOProjectA.Models;
using OwlOProjectA.Services;

namespace OwlOProjectA.Pages.Workshop_Pages
{
    public class myWorkshopModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public List<Models.Workshop> allWorkshop { get; set; }

        public ApplicationUser currentUser { get; set; }

        private readonly ILogger<myWorkshopModel> _logger;
        private WorkshopService _svc;
        public myWorkshopModel(ILogger<myWorkshopModel> logger, WorkshopService service, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _logger = logger;
            _svc = service;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public void OnGet()
        {
            currentUser = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
            //Session["CurrentUser"] = _svc.GetAllWorkshopsByUser(currentUser.Email.ToString());
            //allWorkshop = Session["CurrentUser"];
            allWorkshop = _svc.GetAllWorkshopsByUser(currentUser.Email.ToString());
        }
    }
}
