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
    public class UpdateResourcesModel : PageModel
    {
        [BindProperty]
        public String ErrorMessage { get; set; }
        private ResourceService _resourceService { get; set; }
        [BindProperty]
        public Resources resource { get; set; }

        public UpdateResourcesModel(ResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        public void OnGet(string id, string resourceid)
        {
            Console.WriteLine($"This is route data for update resource {id} {resourceid}");
            resource = _resourceService.GetResource(resourceid);
            resource.Resource_id = resourceid;
            Console.WriteLine($"This is project id {resource.project_id}, {resource.Resource_id}");

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine($"This is resource {resource.project_id}, {resource.Resource_id}, {resource.title}, {resource.link}");
                _resourceService.UpdateResource(resource);
                return Redirect("/OwloPlan/ManageProject/" + resource.project_id);
            }
            else
            {
                ErrorMessage = "An error occured adding a task";
                return Page();

            }
        }
        public IActionResult OnPostDeleteResource(string projectid, string resourceid) {
            _resourceService.DeleteResource(resourceid);
            return Redirect($"/OwloPlan/ManageProject/{projectid}");

        }
    }
}
