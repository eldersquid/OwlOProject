using owlo_plan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Services
{
    public class MeetingService
    {
        private OwloPlanDBContext _context;
        public MeetingService(OwloPlanDBContext context) {
            _context = context;
        }
        public List<Meetings> GetAllMeetings(string project_ID) {
            List<Meetings> AllMeetings = new List<Meetings>();
            AllMeetings = _context.Meetings.Where(b => b.Project_ID.Contains(project_ID)).ToList();
            return AllMeetings;
        }
        //update priority
        public void UpdatePriority(string meeting_id, int priority)
        {
            Meetings meeting = _context.Meetings.Single(b => b.Meeting_ID == meeting_id);
            meeting.priority = priority;
            _context.Update(meeting);
            _context.SaveChanges();

        }
        public Boolean AddMeeting(Meetings meeting)
        {
            _context.Add(meeting);
            _context.SaveChanges();
            return true;
        }
    }
}
