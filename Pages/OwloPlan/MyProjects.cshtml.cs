using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using owlo_plan.Models;
using owlo_plan.Services;
using OwlOProjectA.Areas.Identity.Data;

namespace owlo_plan.Pages
{
    public class MyProjectsModel : PageModel
    {
        [BindProperty]
        public List<Projects> AllMyProjects { get; set; }
        private ProjectService _projectSvc;

        [BindProperty]
        public string userEmail { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
         
        public MyProjectsModel(ProjectService projectservice, UserManager<ApplicationUser> userManager) {
            _projectSvc = projectservice;
            _userManager = userManager;

        }
        public void OnGet()
        {
            userEmail = _userManager.GetUserAsync(User).GetAwaiter().GetResult().Email;

            //this to be converted to session after gabriel is done with login
            AllMyProjects = _projectSvc.GetAllProjects(userEmail);
        }

        //public viewWorkshopModel(WorkshopService service, UserManager<ApplicationUser> userManager)
        //{
        //    _svc = service;
        //    _userManager = userManager;
        //}
        //public void OnGet(int id)
        //{
        //    workshop = _svc.GetWorkshopByID(id);
        //    user = _userManager.GetUserAsync(User).GetAwaiter().GetResult();
        //}
    }
}
