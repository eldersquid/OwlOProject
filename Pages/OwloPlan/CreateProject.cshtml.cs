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
    public class CreateProjectModel : PageModel
    {
        private ProjectService _svc;
        [BindProperty]
        public Projects Project { get; set; }
        [BindProperty]
        public String ErrorMessage { get; set; }

        [BindProperty]
        public string userEmail { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;
        public CreateProjectModel(ProjectService projectservice, UserManager<ApplicationUser> userManager) {
            _svc = projectservice;
            _userManager = userManager;

        }
        public void OnGet()
        {
            userEmail = _userManager.GetUserAsync(User).GetAwaiter().GetResult().Email;

        }
        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                Project.Project_ID = Guid.NewGuid().ToString();
                Project.Owner = userEmail;
                if (_svc.AddProject(Project))
                {
                    ErrorMessage = "Created Successfully";
                    return Redirect("/OwloPlan/MyProjects");
                }
                else
                {
                    ErrorMessage = "Project Title is not Unique";
                }
            }
            else {
                ErrorMessage = "There is an error, please try again";
            }
            return Page();
        }
    }
}
