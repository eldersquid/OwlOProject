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
    public class addSkillsModel : PageModel
    {
        public string ProjectID { get; set; }
        [BindProperty]
        public String ErrorMessage { get; set; }
        private ProjectService _projectsService { get; set; }
        [BindProperty]
        public SkillsNeeded skill { get; set; }

        public addSkillsModel(ProjectService projectService)
        {
            _projectsService = projectService;
        }
        public void OnGet(string id)
        {
            Console.WriteLine($"This is route data {id}");
            skill = new SkillsNeeded();
            skill.Project_ID = id;
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                skill.SkillsNeeded_ID = Guid.NewGuid().ToString();
                _projectsService.AddSkill(skill);
                return Redirect("/OwloPlan/PublishProject/" + skill.Project_ID);
            }
            else
            {
                ErrorMessage = "An error occured adding a task";
                return Page();

            }
        }
    }
}

