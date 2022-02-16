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
    public class planWorkshopModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public Workshop workshop { get; set; }

        public ApplicationUser currentUser { get; set; }

        private WorkshopService _svc;
        public planWorkshopModel(WorkshopService service, UserManager<ApplicationUser> userManager)
        {
            _svc = service;
            _userManager = userManager;
        }
        public void OnGet(int id)
        {
            workshop = _svc.GetWorkshopByID(id);
        }
    }
}
