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
    public class AddResourceModel : PageModel
    {
        [BindProperty]
        public String ErrorMessage { get; set; }
        private ResourceService _resourceService { get; set; }
        [BindProperty]
        public Resources resource { get; set; }

        public AddResourceModel(ResourceService resourceService)
        {
            _resourceService = resourceService;
        }

        public void OnGet(string id)
        {
            Console.WriteLine($"This is route data {id}");
            resource = new Resources();
            resource.project_id = id;
            Console.WriteLine($"This is project id {resource.project_id}");

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                resource.Resource_id = Guid.NewGuid().ToString();
                Console.WriteLine($"This is resource {resource.project_id}, {resource.title}");
                _resourceService.AddResource(resource);
                return Redirect("/OwloPlan/ManageProject/" + resource.project_id);
            }
            else
            {
                ErrorMessage = "An error occured adding a task";
                return Page();

            }
        }
    }
}
