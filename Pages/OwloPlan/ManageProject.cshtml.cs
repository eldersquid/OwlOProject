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
    public class ManageProjectModel : PageModel
    {
        [BindProperty]
        public Projects MyProject { get; set; }
        [BindProperty]
        public List<Resources> AllProjectResources { get; set; }
        [BindProperty]
        public List<TeamMembers> AllTeamMembers { get; set; }
        [BindProperty]
        public List<ProjectTasks> AllTasks { get; set; }
        [BindProperty]
        public List<Meetings> AllMeetings { get; set; }

        [BindProperty]
        public List<JoinRequests> AllJoinRequests { get; set; }

        private ResourceService _resourceService;
        private ProjectService _projectSvc;
        public ManageProjectModel(ProjectService projectservice, ResourceService resourceService) {
            _projectSvc = projectservice;
            _resourceService = resourceService;
        }
        public void OnGet(string id)
        {
            //validate if project is valid, else return to project page
            if (id != null) {
                MyProject = _projectSvc.GetProjectById(id);
                AllProjectResources = _resourceService.GetAllResources(id);
                AllTeamMembers = _projectSvc.GetAllTeamMembers(id);
                AllTasks = _projectSvc.GetAllTask(id);
                AllMeetings = _projectSvc.GetAllMeetings(id);
                AllJoinRequests = _projectSvc.GetAllJoinRequests(id);
            }
        }
        public IActionResult OnPostDeleteTask(string projectid, string id)
        {
            Console.WriteLine($"this is project id {projectid} and id {id}");
            _projectSvc.deletetask(id);
            //_projectSvc.turnRequestToMembier(id);
            return Redirect($"/OwloPlan/ManageProject/{projectid}");
        }
        public IActionResult OnPostDeleteProject(string projectid) {
            _projectSvc.deleteproject(projectid);
            return Redirect("/OwloPlan/MyProjects");
        }
        public IActionResult OnPostAcceptRequest(string projectid, string id) {
            Console.WriteLine($"this is project id {projectid} and id {id}");
            _projectSvc.acceptJoinRequest(id);
            //_projectSvc.turnRequestToMembier(id);
            return Redirect($"/OwloPlan/ManageProject/{projectid}");
        }
        public IActionResult OnPostDenyRequest(string projectid,string id) {
            _projectSvc.denyJoinRequest(id);
            return Redirect($"/OwloPlan/ManageProject/{projectid}");
        }

        public IActionResult OnPostDeleteTeamMember(string projectid, string id) {
            _projectSvc.deleteteammember(id);
            return Redirect($"/OwloPlan/ManageProject/{projectid}");

        }
    }
}
