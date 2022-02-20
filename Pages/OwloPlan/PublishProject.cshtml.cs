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
    public class PublishProjectModel : PageModel
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
        public List<SkillsNeeded> AllSkills { get; set; }
        [BindProperty]
        public List<Causes> AllCauses { get; set; }
        [BindProperty]
        public List<CommunityPartners> AllCommunityPartners { get; set; }

        private ResourceService _resourceService;
        private ProjectService _projectSvc;
        public PublishProjectModel(ProjectService projectservice, ResourceService resourceService)
        {
            _projectSvc = projectservice;
            _resourceService = resourceService;
        }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            MyProject = _projectSvc.GetProjectById(id);
            AllProjectResources =  _resourceService.GetAllResources(id);
            AllTeamMembers = _projectSvc.GetAllTeamMembers(id);
            AllTasks = _projectSvc.GetAllTask(id);
            AllMeetings = _projectSvc.GetAllMeetings(id);
            AllCommunityPartners = _projectSvc.GetAllCommunityPartners(id);
            AllSkills = _projectSvc.GetAllSkills(id);
            AllCauses = _projectSvc.GetAllCauses(id);
            return Page();
        }
        //public void OnGet(string id)
        //{
        //    MyProject = new Projects();
        //    //validate if project is valid, else return to project page
        //    Console.WriteLine("this is id on get", id);
        //        MyProject = _projectSvc.GetProjectById(id);
        //        AllProjectResources = _resourceService.GetAllResources(id);
        //        AllTeamMembers = _projectSvc.GetAllTeamMembers(id);
        //        AllTasks = _projectSvc.GetAllTask(id);
        //        AllMeetings = _projectSvc.GetAllMeetings(id);
        //        AllCommunityPartners = _projectSvc.GetAllCommunityPartners(id);
        //        AllSkills = _projectSvc.GetAllSkills(id);
        //        AllCauses = _projectSvc.GetAllCauses(id);

        //}
        //public IActionResult OnGet(int id)
        //{
        //    MyProject = new Projects();
        //    //validate if project is valid, else return to project page
        //    Console.WriteLine("this is id on get", id);
        //    MyProject = _projectSvc.GetProjectById(id.ToString());
        //    AllProjectResources = _resourceService.GetAllResources(id.ToString());
        //    AllTeamMembers = _projectSvc.GetAllTeamMembers(id.ToString());
        //    AllTasks = _projectSvc.GetAllTask(id.ToString());
        //    AllMeetings = _projectSvc.GetAllMeetings(id.ToString());

        //    AllSkills = _projectSvc.GetAllSkills(id.ToString());
        //    AllCauses = _projectSvc.GetAllCauses(id.ToString());
        //    AllCommunityPartners = _projectSvc.GetAllCommunityPartners(id.ToString());
            
        //    return Page();
        //}
        public IActionResult OnPostPublish(string projectid)
        {
            _projectSvc.publishproject(projectid);
            return Redirect($"/OwloPlan/PublishProject/{projectid}");

        }
        public IActionResult OnPostUnPublish(string projectid)
        {
            _projectSvc.unpublishproject(projectid);
            return Redirect($"/OwloPlan/PublishProject/{projectid}");

        }
        public IActionResult OnPostDeleteSkill(string projectid, string id)
        {
            Console.WriteLine($"this is project id {projectid} and id {id}");
            _projectSvc.deleteskill(id);
            return Redirect($"/OwloPlan/PublishProject/{projectid}");

        }
        public IActionResult OnPostDeleteCause(string projectid, string id)
        {
            Console.WriteLine($"this is project id {projectid} and id {id}");
            _projectSvc.deletecause(id);
            return Redirect($"/OwloPlan/PublishProject/{projectid}");

        }
        public IActionResult OnPostDeleteCommunityPartner(string projectid, string id)
        {
            Console.WriteLine($"this is project id {projectid} and id {id}");
            _projectSvc.deletecommunitypartner(id);
            return Redirect($"/OwloPlan/PublishProject/{projectid}");

        }

    }
}
