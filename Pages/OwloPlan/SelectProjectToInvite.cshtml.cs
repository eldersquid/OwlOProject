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
    public class SelectProjectToInviteModel : PageModel
    {
        [BindProperty]
        public List<Projects> AllMyProjects { get; set; }
        [BindProperty]
        public string userid { get; set; }
        private ProjectService _projectSvc;

        public SelectProjectToInviteModel(ProjectService projectService) {
            _projectSvc = projectService;
        }
        public void OnGet(string id)
        {
            userid = id;
            AllMyProjects = _projectSvc.GetAllProjectsNotMember("nuzul5567@gmail.com",id);
        }
        public IActionResult OnPostInviteToProject(string id, string projectid)
        {
            //add team member
            _projectSvc.AddMemberToProject(id, projectid);
            return Redirect("/OwloPlan/ExploreVolunteers");
        }
    }
}
