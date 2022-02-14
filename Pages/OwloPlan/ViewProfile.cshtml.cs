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
    public class ViewProfileModel : PageModel
    {
        [BindProperty]
        public Owlers owler { get; set; }
        [BindProperty]
        public List<ProjectWithAllAttributes> AllMyProjects { get; set; }

        [BindProperty]
        public List<userSkills> userSkills { get; set; }
        [BindProperty]
        public List<userInterests> userInterests { get; set; }

        private ResourceService _resourceService;
        private ProjectService _projectSvc;
        public ViewProfileModel(ProjectService projectservice, ResourceService resourceService)
        {
            _projectSvc = projectservice;
            _resourceService = resourceService;
        }
        public void OnGet(string id)
        {
            //validate if project is valid, else return to project page

            owler = _projectSvc.GetOwler(id);
            userSkills = _projectSvc.GetAllUserSkills(id);
            userInterests = _projectSvc.GetAllUserInterests(id);
            AllMyProjects = _projectSvc.GetProjectsWithAttributeById(id);

        }

 
    }
}
