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
    public class MyProjectsModel : PageModel
    {
        [BindProperty]
        public List<Projects> AllMyProjects { get; set; }
        private ProjectService _projectSvc;
        public MyProjectsModel(ProjectService projectservice) {
            _projectSvc = projectservice;
        }
        public void OnGet()
        {
            //this to be converted to session after gabriel is done with login
            AllMyProjects = _projectSvc.GetAllProjects("nuzul5567@gmail.com");
        }
    }
}
