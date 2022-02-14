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
    public class AddMeetingModel : PageModel
    {
        [BindProperty]
        public Meetings meeting {get;set;}
        [BindProperty]
        public string ErrorMessage { get; set; }
        private readonly MeetingService _meetingService;

        public AddMeetingModel(MeetingService meetingService) {
            _meetingService = meetingService;
        }
        public void OnGet(string projectid)
        {
            meeting = new Meetings();
            meeting.Project_ID = projectid;

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                meeting.Meeting_ID = Guid.NewGuid().ToString();
                meeting.Meeting_Caller = "Nuzul Firdaly";
                _meetingService.AddMeeting(meeting);
                return Redirect("/OwloPlan/ManageProject/" + meeting.Project_ID);
            }
            else
            {
                ErrorMessage = "An error occured adding a task";
                return Page();

            }
        }
    }
}
