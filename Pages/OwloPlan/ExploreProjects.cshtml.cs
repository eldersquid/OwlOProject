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
    public class ExploreProjectsModel : PageModel
    {
        [BindProperty]
        public List<ProjectWithAllAttributes> AllMyProjects { get; set; }
        [BindProperty]
        public string causeChosen { get; set; }
        private ProjectService _projectSvc;
        public ExploreProjectsModel(ProjectService projectService) {
            _projectSvc = projectService;
        }
        public void OnGet(string cause)
        {
            causeChosen = cause;
            AllMyProjects = _projectSvc.GetProjectsByCause(cause.ToLower());

        }
    }
}
