using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using owlo_plan.Services;
using owlo_plan.Models;

namespace owlo_plan.Pages
{
    public class addUserSkillModel : PageModel
    {
        private ProjectService _projectsService { get; set; }
        [BindProperty]
        public userSkills userInterest { get; set; }

        public addUserSkillModel(ProjectService projectService)
        {
            _projectsService = projectService;
        }
        public void OnGet()
        {
            var userid = "nuzul5567@gmail.com";
            userInterest = new userSkills();
            userInterest.Project_ID = userid;

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                userInterest.userSkills_ID = Guid.NewGuid().ToString();
                _projectsService.AddUserSkill(userInterest);
                return Redirect("/OwloPlan/MyProfile");
            }
            else
            {
                return Page();

            }
        }
    }
}
