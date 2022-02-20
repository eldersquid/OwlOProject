using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using owlo_plan.Models;
using owlo_plan.Services;

namespace owlo_plan.Pages
{
    public class addUserInterestsModel : PageModel
    {
        private ProjectService _projectsService { get; set; }
        [BindProperty]
        public userInterests userInterest { get; set; }

        public addUserInterestsModel(ProjectService projectService)
        {
            _projectsService = projectService;
        }
        public void OnGet()
        {
            var userid = "nuzul5567@gmail.com";
            userInterest = new userInterests();
            userInterest.Project_ID = userid;

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                userInterest.userInterest_ID = Guid.NewGuid().ToString();
                _projectsService.AddUserInterest(userInterest);
                return Redirect("/OwloPlan/MyProfile");
            }
            else
            {
                return Page();

            }
        }
    }
}

