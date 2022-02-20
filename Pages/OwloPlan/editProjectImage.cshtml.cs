using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using owlo_plan.Models;
using owlo_plan.Services;

namespace OwlOProjectA.Pages.OwloPlan
{
    public class editProjectImageModel : PageModel
    {
        [BindProperty]
        public Projects Project { get; set; }
        private ProjectService _projectSvc;
        [BindProperty]
        public String ErrorMessage { get; set; }
        public editProjectImageModel(ProjectService projectservice)
        {
            _projectSvc = projectservice;
        }
        public void OnGet(string id)
        {
            Project = _projectSvc.GetProjectById(id);
            Console.WriteLine("this is on get", Project.Project_ID, Project.Description, Project.Title);
        }
        public IActionResult OnPost()
        {

            Console.WriteLine("this is editDescription", Project.Description, Project.Project_ID);
            _projectSvc.UpdateProject(Project);
            return Redirect("/OwloPlan/PublishProject/" + Project.Project_ID);

        }
    }
}
