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
    public class MyProfileModel : PageModel
    {
        [BindProperty]
        public List<ProjectWithAllAttributes> AllMyProjects { get; set; }
 
        [BindProperty]
        public List<userSkills> userSkills { get; set; }
        [BindProperty]
        public List<userInterests> userInterests { get; set; }

        private ResourceService _resourceService;
        private ProjectService _projectSvc;
        public MyProfileModel(ProjectService projectservice, ResourceService resourceService)
        {
            _projectSvc = projectservice;
            _resourceService = resourceService;
        }
        public void OnGet()
        {
            var userid = "nuzul5567@gmail.com";
            //validate if project is valid, else return to project page
        

            userSkills = _projectSvc.GetAllUserSkills(userid);
            userInterests = _projectSvc.GetAllUserInterests(userid);
            AllMyProjects = _projectSvc.GetProjectsWithAttributeById("nuzul5567@gmail.com");


            
        }


        
        public IActionResult OnPostDeleteSkill(string id)
        {
            _projectSvc.deleteuserskill(id);
            return Redirect($"/OwloPlan/MyProfile");

        }
        public IActionResult OnPostDeleteInterest(string id)
        {
            _projectSvc.deleteuserinterest(id);
            return Redirect($"/OwloPlan/MyProfile");

        }


    }
}

