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
    public class editDescriptionModel : PageModel
    {
        [BindProperty]
        public Projects project { get; set; }
        private ProjectService _projectSvc;
        [BindProperty]
        public String ErrorMessage { get; set; }
        public editDescriptionModel(ProjectService projectservice)
        {
            _projectSvc = projectservice;
        }
        public void OnGet(string id)
        {
            project = _projectSvc.GetProjectById(id);
            Console.WriteLine("this is on get", project.Project_ID, project.Description, project.Title);
        }
        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                Console.WriteLine("this is editDescription", project.Description, project.Project_ID);
                _projectSvc.UpdateProject(project);
                return Redirect("/OwloPlan/PublishProject/" + project.Project_ID);
            }
            else
            {
                return Page();

            }
        }
    }
}
