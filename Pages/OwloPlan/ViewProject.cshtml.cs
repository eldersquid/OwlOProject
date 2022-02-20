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
    public class ViewProjectModel : PageModel
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

        [BindProperty]
        public Boolean joinRequestExist { get; set; }
        [BindProperty]
        public string projectID { get; set; }


        private ResourceService _resourceService;
        private ProjectService _projectSvc;
        [BindProperty]
        public string userEmail { get; set; }
        private readonly UserManager<ApplicationUser> _userManager;

        public ViewProjectModel(ProjectService projectservice, ResourceService resourceService, UserManager<ApplicationUser> userManager)
        {
            _projectSvc = projectservice;
            _resourceService = resourceService;
            _userManager = userManager;

        }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            //validate if project is valid, else return to project page
            if (id != null)
            {
                MyProject = _projectSvc.GetProjectById(id);
                AllProjectResources = _resourceService.GetAllResources(id);
                AllTeamMembers = _projectSvc.GetAllTeamMembers(id);
                AllTasks = _projectSvc.GetAllTask(id);
                AllMeetings = _projectSvc.GetAllMeetings(id);

                AllSkills = _projectSvc.GetAllSkills(id);
                AllCauses = _projectSvc.GetAllCauses(id);
                AllCommunityPartners = _projectSvc.GetAllCommunityPartners(id);
                userEmail = _userManager.GetUserAsync(User).GetAwaiter().GetResult().Email;


                //check whether join request exist
                joinRequestExist = _projectSvc.checkJoinRequest(userEmail, MyProject.Project_ID);
            }
            return Page();
        }
        public IActionResult OnPostCancelInvitation() 
        {
            _projectSvc.CancelInvitaiton(userEmail, projectID);
            return Redirect("/OwloPlan/ViewProject/" + projectID);
            
        }
    }
}
