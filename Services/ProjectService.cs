using owlo_plan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Services
{
    public class ProjectService
    {
        private OwloPlanDBContext _context;
        public ProjectService(OwloPlanDBContext context) {
            _context = context;
        }
        public Projects GetProjectById(string id) {
            Console.WriteLine("This is get projec tby id", id);
            //\https://stackoverflow.com/questions/10344915/convert-iqueryable-to-custom-class
            Projects project =  _context.Projects.Where(b => b.Project_ID == id).First();
            return project;
        }
        public List<Projects> GetAllProjects(string Email) {
            List<Projects> AllProjects = new List<Projects>();
            AllProjects = _context.Projects.Where(b => b.Owner.ToLower() == Email.ToLower()).ToList();
            return AllProjects;

        }
        //get all project along if you are a member of it as well
        public Boolean AddProject(Projects project) {
            foreach (Projects projects in _context.Projects.ToList()) {
                if (project.Title == projects.Title) {  //if it matches, means project title already exist
                    return false;
                }
            }
            _context.Add(project);
            _context.SaveChanges();
            return true;
        }

        public List<ProjectTasks> GetAllTask(string project_ID) {
            List<ProjectTasks> AllProjects = new List<ProjectTasks>();
            AllProjects = _context.ProjectTasks.Where(b => b.Project_ID.Contains(project_ID)).ToList();
            return AllProjects;
        }
        public void AddTask(ProjectTasks task) {
            _context.Add(task);
            _context.SaveChanges();
        }
        public void deletetask(string taskid) {
            ProjectTasks task = _context.ProjectTasks.Where(b => b.ProjectTasks_ID == taskid).First();
            _context.Remove(task);
            _context.SaveChanges();
        }
        public void deleteproject(string projectid) {
            Projects project = _context.Projects.Where(b => b.Project_ID == projectid).First();
            _context.Remove(project);
            //remove everything associate to the project
            List<Causes> causes = _context.Causes.Where(b => b.Project_ID == projectid).ToList();
            _context.Causes.RemoveRange(causes);
            List<CommunityPartners> coms = _context.CommunityPartners.Where(b => b.Project_ID == projectid).ToList();
            _context.CommunityPartners.RemoveRange(coms);
            List<JoinRequests> j = _context.JoinRequests.Where(b => b.Project_ID == projectid).ToList();
            _context.JoinRequests.RemoveRange(j);
            List<Resources> r = _context.Resources.Where(b => b.project_id == projectid).ToList();
            _context.Resources.RemoveRange(r);
            List<ProjectTasks> pt = _context.ProjectTasks.Where(b => b.Project_ID == projectid).ToList();
            _context.ProjectTasks.RemoveRange(pt);
            List<TeamMembers> tm = _context.TeamMembers.Where(b => b.Project_ID == projectid).ToList();
            _context.TeamMembers.RemoveRange(tm);
            List<Meetings> m = _context.Meetings.Where(b => b.Project_ID == projectid).ToList();
            _context.Meetings.RemoveRange(m);
            List<SkillsNeeded> s = _context.SkillsNeeded.Where(b => b.Project_ID == projectid).ToList();
            _context.SkillsNeeded.RemoveRange(s);
            _context.SaveChanges();

        }
        public List<TeamMembers> GetAllTeamMembers(string project_id)
        {
            List<TeamMembers> AllResources = new List<TeamMembers>();
            AllResources = _context.TeamMembers.Where(b => b.Project_ID.Contains(project_id)).ToList();
            return AllResources;
        }

        public List<Meetings> GetAllMeetings(string project_ID)
        {
            List<Meetings> AllMeetings = new List<Meetings>();
            AllMeetings = _context.Meetings.Where(b => b.Project_ID.Contains(project_ID)).ToList();
            return AllMeetings;
        }

        //AllSkills = _projectSvc.GetAllSkilsl(id);
        //        AllCauses = _projectSvc.GetAllCauses(id);
        //        AllCommunityPartners = _projectSvc.GetAllCommunityPartners(id);
        public List<SkillsNeeded> GetAllSkills(string project_ID)
        {
            List<SkillsNeeded> AllSkills = new List<SkillsNeeded>();
            AllSkills = _context.SkillsNeeded.Where(b => b.Project_ID.Contains(project_ID)).ToList();
            return AllSkills;
        }
        public List<Causes> GetAllCauses(string project_ID)
        {
            List<Causes> AllCauses = new List<Causes>();
            AllCauses = _context.Causes.Where(b => b.Project_ID.Contains(project_ID)).ToList();
            return AllCauses;
        }
        public List<CommunityPartners> GetAllCommunityPartners(string project_ID)
        {
            List<CommunityPartners> AllCom = new List<CommunityPartners>();
            AllCom = _context.CommunityPartners.Where(b => b.Project_ID.Contains(project_ID)).ToList();
            return AllCom;
        }
        public void AddSkill(SkillsNeeded skill)
        {
            _context.Add(skill);
            _context.SaveChanges();
        }
        public void AddCause(Causes cause)
        {
            _context.Add(cause);
            _context.SaveChanges();
        }
        public void AddCommunityPartner(CommunityPartners com)
        {
            _context.Add(com);
            _context.SaveChanges();
        }
        public void deleteskill(string taskid)
        {
            SkillsNeeded task = _context.SkillsNeeded.Where(b => b.SkillsNeeded_ID == taskid).First();
            _context.Remove(task);
            _context.SaveChanges();
        }
        public void deletecause(string taskid)
        {
            Causes task = _context.Causes.Where(b => b.Causes_id == taskid).First();
            _context.Remove(task);
            _context.SaveChanges();
        }
        public void deletecommunitypartner(string taskid)
        {
            CommunityPartners task = _context.CommunityPartners.Where(b => b.CommunityPartners_ID == taskid).First();
            _context.Remove(task);
            _context.SaveChanges();
        }

        public void publishproject(string projectid) {
            Projects project = _context.Projects.Where(b => b.Project_ID == projectid).FirstOrDefault();
            project.Published = true;
            _context.Update(project);
            _context.SaveChanges();
        
        }
        public void unpublishproject(string projectid)
        {
            Projects project = _context.Projects.Where(b => b.Project_ID == projectid).FirstOrDefault();
            project.Published = false;
            _context.Update(project);
            _context.SaveChanges();

        }

        public void UpdateResource(Resources resources)
        {
            Console.WriteLine($"this is in resourceservice, {resources.title}, {resources.link}");
            Resources resource = _context.Resources.Where(b => b.Resource_id == resources.Resource_id).First();
            resource.link = resources.link;
            resource.title = resources.title;
            _context.Update(resource);
            _context.SaveChanges();
        }


        public List<ProjectWithAllAttributes> GetProjectsByCause(string cause) {
            List<ProjectWithAllAttributes> listOfProjectWithAllAttributes = new List<ProjectWithAllAttributes>();
            List<Projects> projectsThatmatched = new List<Projects>();
            List<Projects> allProjects = new List<Projects>();
            allProjects = _context.Projects.ToList();
            //checking whether project's cause matches, if so append to projects with same cause
            foreach (var project in allProjects) {
                List<Causes> causes = _context.Causes.Where(b => b.Project_ID == project.Project_ID).ToList();
                Boolean causeMatch = false;
                foreach (var i in causes) {
                    if (i.Cause == cause) {
                        causeMatch = true;
                    }
                }
                if (causeMatch == true) {
                    if (project.Published == true) {
                        projectsThatmatched.Add(project);

                    }
                }
            }

            //for projects that maches
            if (projectsThatmatched.Count > 0) {
                foreach (var i in projectsThatmatched) {
                    ProjectWithAllAttributes projectWith = new ProjectWithAllAttributes();
                    projectWith.Project = i;
                    projectWith.Causes = _context.Causes.Where(b => b.Project_ID == i.Project_ID).ToList();
                    projectWith.CommunityPartners = _context.CommunityPartners.Where(b => b.Project_ID == i.Project_ID).ToList();
                    projectWith.SkillsNeeded = _context.SkillsNeeded.Where(b => b.Project_ID == i.Project_ID).ToList();
                    listOfProjectWithAllAttributes.Add(projectWith);
                }
            }
            return listOfProjectWithAllAttributes;
        }

        public void UpdateProject(Projects projectLol)
        {
            _context.Update(projectLol);
            _context.SaveChanges();

        }
        public void AddJoinRequest(JoinRequests joinRequests)
        {
            _context.Add(joinRequests);
            _context.SaveChanges();
        }
        public Boolean checkJoinRequest(string user, string projectid) {
            return _context.JoinRequests.Any(b => b.User == user && b.Project_ID == projectid);
            //Console.WriteLine($"this is in resourceservice, {resources.title}, {resources.link}");
            //Resources resource = _context.Resources.Where(b => b.Resource_id == resources.Resource_id).First();
            //resource.link = resources.link;
            //resource.title = resources.title;
            //_context.Update(resource);
            //_context.SaveChanges();
        }
        public void CancelInvitaiton(string userid, string projectid) {
            JoinRequests joinRequests = _context.JoinRequests.Where(b => b.User == userid && b.Project_ID == projectid).First();
            _context.Remove(joinRequests);
            _context.SaveChanges();
        }
        public List<ProjectWithAllAttributes> GetProjectsWithAttributeById(string user)
        {
            List<ProjectWithAllAttributes> listOfProjectWithAllAttributes = new List<ProjectWithAllAttributes>();
            Owlers owler = _context.Owlers.Where(b => b.Email == user).First();

            List<Projects> allProjects = new List<Projects>();
            allProjects = _context.Projects.Where(b=> b.Owner == user && b.Published==true).ToList();

            //also displaying projects the user is a member of    
            List<TeamMembers> projectMembers = _context.TeamMembers.Where(b => b.UserName == owler.username).ToList();

            foreach (var row in projectMembers) {
                allProjects.Add(_context.Projects.Where(b => b.Project_ID == row.Project_ID).First());

            }

            //for projects that maches
            if (allProjects.Count > 0)
            {
                foreach (var i in allProjects)
                {
                    ProjectWithAllAttributes projectWith = new ProjectWithAllAttributes();
                    projectWith.Project = i;
                    projectWith.Causes = _context.Causes.Where(b => b.Project_ID == i.Project_ID).ToList();
                    projectWith.CommunityPartners = _context.CommunityPartners.Where(b => b.Project_ID == i.Project_ID).ToList();
                    projectWith.SkillsNeeded = _context.SkillsNeeded.Where(b => b.Project_ID == i.Project_ID).ToList();
                    if (i.Owner != user)
                    {
                        projectWith.MyRole = _context.TeamMembers.Where(b => b.Project_ID == i.Project_ID && b.UserName == owler.username).First().role;
                    }
                    else {
                        projectWith.MyRole = "Owner";
                    }
                    listOfProjectWithAllAttributes.Add(projectWith);
                }
            }
            return listOfProjectWithAllAttributes;
        }

        //userSkills = _projectSvc.GetAllUserSkills(userid);
        //        userInterests = _projectSvc.GetAllUserInterests(userid);

        public List<userInterests> GetAllUserInterests(string userid) {
            List<userInterests> AllMeetings = new List<userInterests>();
            AllMeetings = _context.userInterests.Where(b => b.Project_ID == userid).ToList();
            return AllMeetings;
        }
        public List<userSkills> GetAllUserSkills(string userid)
        {
            List<userSkills> AllMeetings = new List<userSkills>();
            AllMeetings = _context.userSkills.Where(b => b.Project_ID == userid).ToList();
            return AllMeetings;
        }


        public void AddUserSkill(userSkills userInterest) {
            _context.Add(userInterest);
            _context.SaveChanges();
        }
        public void AddUserInterest(userInterests userInterest)
        {
            _context.Add(userInterest);
            _context.SaveChanges();

        }
        public void deleteuserskill(string taskid)
        {
            userSkills task = _context.userSkills.Where(b => b.userSkills_ID == taskid).First();
            _context.Remove(task);
            _context.SaveChanges();
        }
        public void deleteuserinterest(string taskid)
        {
            userInterests task = _context.userInterests.Where(b => b.userInterest_ID== taskid).First();
            _context.Remove(task);
            _context.SaveChanges();
        }

        public List<OwlerWithAttributes> GetAllOwlers() {
            List<OwlerWithAttributes> allowlerwithattributes = new List<OwlerWithAttributes>();


            List<Owlers> allOwlers = _context.Owlers.ToList();
            foreach (var i in allOwlers) {
                OwlerWithAttributes owlerwithattributes = new OwlerWithAttributes();
                owlerwithattributes.owler = i;
                owlerwithattributes.userInterests = _context.userInterests.Where(b => b.Project_ID == i.Email).ToList();
                owlerwithattributes.userskills = _context.userSkills.Where(b => b.Project_ID == i.Email).ToList();
                allowlerwithattributes.Add(owlerwithattributes);
            }
            return allowlerwithattributes;

        }

        public Owlers GetOwler(string id) {
            return _context.Owlers.Where(b => b.Email == id).First();
        }
        public List<JoinRequests> GetAllJoinRequests(string id) {
            return _context.JoinRequests.Where(b => b.Project_ID == id).ToList();
        }
        public void denyJoinRequest(string id) {
            JoinRequests task = _context.JoinRequests.Where(b => b.JoinRequest_id == id).First();
            _context.Remove(task);
            _context.SaveChanges();
        }
        public void acceptJoinRequest(string id) {
            JoinRequests task = _context.JoinRequests.Where(b => b.JoinRequest_id == id).First();
            Owlers owler = _context.Owlers.Where(b => b.Email == task.User).First();
            TeamMembers team = new TeamMembers();
            team.TeamMember_ID = task.JoinRequest_id;
            team.Project_ID = task.Project_ID;
            team.role = "Volunteer";
            team.UserName = owler.username;
            _context.Add(team);
            _context.SaveChanges();
            _context.Remove(task);
            _context.SaveChanges();
        }
        //public void turnRequestToMembier(string id) {
        //    //JoinRequests task = _context.JoinRequests.Where(b => b.JoinRequest_id == id).First();
        //    //Owlers owler = _context.Owlers.Where(b => b.Email == task.User).First();
        //    //TeamMembers team = new TeamMembers();
        //    //team.TeamMember_ID = task.JoinRequest_id;
        //    //team.Project_ID = task.Project_ID;
        //    //team.role = "Volunteer";
        //    //team.UserName = owler.username;

        //}
        public void AddMemberToProject(string id, string projectid) {
            TeamMembers team = new TeamMembers();

            Owlers owler = _context.Owlers.Where(b => b.Email ==id).First();
            team.TeamMember_ID = Guid.NewGuid().ToString();
            team.Project_ID = projectid;
            team.UserName = owler.username;
            team.role = "Volunteer";
            _context.Add(team);
            _context.SaveChanges();



        }

        public List<Projects> GetAllProjectsNotMember(string owner,string userid) {
            Owlers owler = _context.Owlers.Where(b => b.Email == userid).First();
            //if projectid matches ontop project, it means it exist 
            return _context.Projects.Where(a => a.Owner == owner && (_context.TeamMembers.Where(b => b.UserName == owler.username && b.Project_ID == a.Project_ID).Any()) == false).ToList();
        
        }

        //public List<Projects> GetAllAssociatedProjects(string id) {
        //    List<Projects> allprojects = _context.Owlers
        //    Owlers owler = _context.Owlers.Where(b => b.Email == id).First();
        //    List<TeamMembers> member = _context.TeamMembers.Where(b => b.UserName == owler.username).ToList();

        //    foreach(var projectApartOf in member)
        //    {
        //        allprojects.Add(_context.Projects.Where(b => b.Project_ID == projectApartOf.Project_ID).First());

        //    }

        //}

        public void deleteteammember(string id)
        {
            _context.Remove(_context.TeamMembers.Where(b => b.TeamMember_ID == id).FirstOrDefault());
            _context.SaveChanges();
        }
    }
}
