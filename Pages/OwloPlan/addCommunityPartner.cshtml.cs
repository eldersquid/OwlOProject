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
    public class addCommunityPartnerModel : PageModel
    {
        public string ProjectID { get; set; }
        [BindProperty]
        public String ErrorMessage { get; set; }
        private ProjectService _projectsService { get; set; }
        [BindProperty]
        public CommunityPartners CommunityPartner { get; set; }

        public addCommunityPartnerModel(ProjectService projectService)
        {
            _projectsService = projectService;
        }
        public void OnGet(string id)
        {
            Console.WriteLine($"This is route data {id}");
            CommunityPartner = new CommunityPartners();
            CommunityPartner.Project_ID = id;
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                CommunityPartner.CommunityPartners_ID = Guid.NewGuid().ToString();
                _projectsService.AddCommunityPartner(CommunityPartner);
                return Redirect("/OwloPlan/PublishProject/" + CommunityPartner.Project_ID);
            }
            else
            {
                ErrorMessage = "An error occured adding a task";
                return Page();

            }
        }
    }
}

