using owlo_plan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Services
{
    public class ProjectDetails
    {
        private OwloPlanDBContext _context;
        public ProjectDetails(OwloPlanDBContext context)
        {
            _context = context;
        }
        public Projects GetProjectById(string id)
        {
            //\https://stackoverflow.com/questions/10344915/convert-iqueryable-to-custom-class
            Projects project = _context.Projects.Where(b => b.Project_ID == id).First();
            return project;
        }
        public List<SkillsNeeded> GetAllSkills(string project_id)
        {
            List<SkillsNeeded> AllResources = new List<SkillsNeeded>();
            AllResources = _context.SkillsNeeded.Where(b => b.Project_ID.Contains(project_id)).ToList();
            return AllResources;
        }
        public void AddSkills(SkillsNeeded skillsNeeded)
        {
            _context.Add(skillsNeeded);
            _context.SaveChanges();
        }
        public List<CommunityPartners> GetAllCommunityPartners(string project_id)
        {
            List<CommunityPartners> AllResources = new List<CommunityPartners>();
            AllResources = _context.CommunityPartners.Where(b => b.Project_ID.Contains(project_id)).ToList();
            return AllResources;
        }
        public void AddCommunityPartner(CommunityPartners communityPartner) {
            _context.Add(communityPartner);
            _context.SaveChanges();
        }
        public void DeleteCommunityPartner(string communityID)
        {
            CommunityPartners communityPartner = _context.CommunityPartners.Where(b => b.CommunityPartners_ID == communityID).First();
            _context.Remove(communityPartner);
            _context.SaveChanges();
        }
        public List<Causes> GetAllCauses(string project_id)
        {
            List<Causes> AllResources = new List<Causes>();
            AllResources = _context.Causes.Where(b => b.Project_ID.Contains(project_id)).ToList();
            return AllResources;
        }
        public void AddCauses(Causes cause)
        {
            _context.Add(cause);
            _context.SaveChanges();
        }
        public void DeleteCause(string cause_id)
        {
            Causes cause = _context.Causes.Where(b => b.Causes_id == cause_id).First();
            _context.Remove(cause);
            _context.SaveChanges();
        }
        public List<TeamMembers> GetAllTeamMembers(string project_id)
        {
            List<TeamMembers> AllResources = new List<TeamMembers>();
            AllResources = _context.TeamMembers.Where(b => b.Project_ID.Contains(project_id)).ToList();


            return AllResources;
        }

    }
}
