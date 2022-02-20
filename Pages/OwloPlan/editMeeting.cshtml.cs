using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using owlo_plan.Models;
using owlo_plan.Services;

namespace OwlOProjectA.Pages.OwloPlan
{
    public class editMeetingModel : PageModel
    {
        [BindProperty]
        public Meetings meeting { get; set; }
        [BindProperty]
        public string ErrorMessage { get; set; }
        private readonly MeetingService _meetingService;

        public editMeetingModel(MeetingService meetingService)
        {
            _meetingService = meetingService;
        }
        public void OnGet(string id)
        {
            meeting = _meetingService.GetMeeting(id);

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _meetingService.UpdateMeeting(meeting);
                return Redirect("/OwloPlan/ManageProject/" + meeting.Project_ID);
            }
            else
            {
                ErrorMessage = "An error occured adding a task";
                return Page();

            }
        }
        public IActionResult OnPostDeleteMeeting(string projectid,string id)
        {
            _meetingService.DeleteMeeting(id);
            return Redirect($"/OwloPlan/ManageProject/{projectid}");

        }
    }
}
