using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Areas.Identity.Data;
using OwlOProjectA.Models;
using OwlOProjectA.Services;

namespace OwlOProjectA.Pages.Workshop_Pages
{
    public class createWorkshopModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUser currentUser { get; set; }

        private WorkshopService _svc;
        public createWorkshopModel( WorkshopService service, UserManager<ApplicationUser> userManager)
        {
            _svc = service;
            _userManager = userManager;
        }
        public IActionResult OnGet()
        {
            currentUser = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
            Workshop workshop = new Workshop();
            workshop.Name = "Untitled";
            workshop.Image = "/WorkshopImages/noimage.png";
            workshop.Description = "There is no description.";
            workshop.Summary = "There is no summary.";
            workshop.Date = DateTime.Now;

            workshop.ownerEmail = currentUser.Email.ToString();

            _svc.AddWorkshop(workshop);
            return Redirect("/Workshop_Pages/myWorkshop");
        }
    }
}
