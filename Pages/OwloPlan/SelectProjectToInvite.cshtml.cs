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
    public class SelectProjectToInviteModel : PageModel
    {
        [BindProperty]
        public List<Projects> AllMyProjects { get; set; }
        [BindProperty]
        public string userid { get; set; }
        private ProjectService _projectSvc;

        [BindProperty]
        public ApplicationUser user { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;


        public SelectProjectToInviteModel(ProjectService projectService, UserManager<ApplicationUser> userManager) {
            _projectSvc = projectService;
            _userManager = userManager;
        }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            user = _userManager.GetUserAsync(User).GetAwaiter().GetResult();

            userid = id;
            AllMyProjects = _projectSvc.GetAllProjectsNotMember(user.Email,id);
            return Page();
        }
        public IActionResult OnPostInviteToProject(string id, string projectid)
        {
            //add team member
            _projectSvc.AddMemberToProject(id, projectid);
            return Redirect("/OwloPlan/ExploreVolunteers");
        }
    }
}
