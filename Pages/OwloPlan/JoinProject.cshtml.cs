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
    public class JoinProjectModel : PageModel
    {
        [BindProperty]
        public string title { get; set; }
        [BindProperty]
        public string project_ID { get; set; }
        [BindProperty]
        public JoinRequests joinRequest { get; set; }
        private ProjectService _projectSvc { get; set;}
        public JoinProjectModel(ProjectService projectService) {
            _projectSvc = projectService;
        }
        public IActionResult OnGet(string id)
        {
           
            Projects projects = _projectSvc.GetProjectById(id);
            title = projects.Title;
            project_ID = projects.Project_ID;

            if (_projectSvc.checkJoinRequest("nuzul5567@gmail.com", project_ID) == true)
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

                joinRequest.User = "nuzul5567@gmail.com";
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
