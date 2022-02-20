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

namespace OwlOProjectA.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public List<Models.Workshop> allWorkshop { get; set; }

        public ApplicationUser currentUser { get; set; }

        private WorkshopService _svc;
        public IndexModel(WorkshopService service, UserManager<ApplicationUser> userManager)
        {
            _svc = service;
            _userManager = userManager;
        }
        public void OnGet()
        {
            currentUser = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
            //Session["CurrentUser"] = _svc.GetAllWorkshopsByUser(currentUser.Email.ToString());
            //allWorkshop = Session["CurrentUser"];
            allWorkshop = _svc.GetAllWorkshops();
        }
    }
}
