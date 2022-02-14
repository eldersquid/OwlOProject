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
    public class CreateProjectModel : PageModel
    {
        private ProjectService _svc;
        [BindProperty]
        public Projects Project { get; set; }
        [BindProperty]
        public String ErrorMessage { get; set; }
        public CreateProjectModel(ProjectService projectservice) {
            _svc = projectservice;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                Project.Project_ID = Guid.NewGuid().ToString();
                Project.Owner = "nuzul5567@gmail.com";
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
