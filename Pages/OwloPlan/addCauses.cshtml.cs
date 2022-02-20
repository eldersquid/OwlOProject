using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using owlo_plan.Services;
using owlo_plan.Models;
namespace owlo_plan.Pages
{
    public class addCausesModel : PageModel
    {
        public string ProjectID { get; set; }
        [BindProperty]
        public String ErrorMessage { get; set; }
        private ProjectService _projectsService { get; set; }
        [BindProperty]
        public Causes cause{ get; set; }

        public addCausesModel(ProjectService projectService)
        {
            _projectsService = projectService;
        }
        public void OnGet(string id)
        {
            Console.WriteLine($"This is route data {id}");
            cause = new Causes();
            cause.Project_ID = id;
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                cause.Causes_id = Guid.NewGuid().ToString();
                _projectsService.AddCause(cause);
                return Redirect("/OwloPlan/PublishProject/" + cause.Project_ID);
            }
            else
            {
                ErrorMessage = "An error occured adding a task";
                return Page();

            }
        }
    }
}
