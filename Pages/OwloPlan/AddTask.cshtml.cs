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
    public class AddTaskModel : PageModel
    {
        public string ProjectID { get; set; }
        [BindProperty]
        public String ErrorMessage { get; set; }
        private ProjectService _projectsService { get; set; }
        [BindProperty]
        public ProjectTasks projectTask { get; set; }

        public AddTaskModel(ProjectService projectService) {
            _projectsService = projectService;
        }
        public void OnGet(string id)
        {
            Console.WriteLine($"This is route data {id}");
            projectTask = new ProjectTasks();
            projectTask.Project_ID = id;
            projectTask.timestamp = DateTime.Now;
            projectTask.owner = "Nuzul Firdaly";
            Console.WriteLine($"This is project id {projectTask.Project_ID}");

        }
        public IActionResult OnPost() {
            if (ModelState.IsValid)
            {
                projectTask.ProjectTasks_ID = Guid.NewGuid().ToString();
                Console.WriteLine($"This is task {projectTask.Project_ID}, {projectTask.task}");
                _projectsService.AddTask(projectTask);
                return Redirect("/OwloPlan/ManageProject/" + projectTask.Project_ID);
            }
            else {
                ErrorMessage = "An error occured adding a task";
                return Page();

            }
        }
    }
}
