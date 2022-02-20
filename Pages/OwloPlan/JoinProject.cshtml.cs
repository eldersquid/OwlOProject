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
    public class JoinProjectModel : PageModel
    {
        [BindProperty]
        public string title { get; set; }
        [BindProperty]
        public string project_ID { get; set; }
        [BindProperty]
        public JoinRequests joinRequest { get; set; }
        private ProjectService _projectSvc { get; set;}

        [BindProperty]
        public string userEmail { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;


        public JoinProjectModel(ProjectService projectService, UserManager<ApplicationUser> userManager) {
            _projectSvc = projectService;
            _userManager = userManager;

        }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            userEmail = _userManager.GetUserAsync(User).GetAwaiter().GetResult().Email;

            Projects projects = _projectSvc.GetProjectById(id);
            title = projects.Title;
            project_ID = projects.Project_ID;

            if (_projectSvc.checkJoinRequest(userEmail, project_ID) == true)
            {
                return Redirect("/OwloPlan/ViewProject/" + project_ID);
            }
            else {
                return Page();
            }
        }
        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                joinRequest.JoinRequest_id = Guid.NewGuid().ToString();

                joinRequest.User = userEmail;
                joinRequest.Project_ID = project_ID;
                _projectSvc.AddJoinRequest(joinRequest);
                return Redirect("/OwloPlan/ViewProject/" + joinRequest.Project_ID);
            }
            else {
                return Page();
            }
        }
    }
}
