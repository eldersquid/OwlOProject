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
    public class ExploreVolunteersModel : PageModel
    {
        [BindProperty]
        public List<OwlerWithAttributes> AllOwlers { get; set; }
        private ProjectService _projectSvc;
        public ExploreVolunteersModel(ProjectService projectService) {
            _projectSvc = projectService;
        }
        public void OnGet()
        {
            AllOwlers = _projectSvc.GetAllOwlers();
        }
    }
}
