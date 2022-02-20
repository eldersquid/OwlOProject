using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    public class ProjectWithAllAttributes
    {
        public Projects Project { get; set; }
        //title, description, image, members
        public List<Causes> Causes { get; set; }
        public List<SkillsNeeded> SkillsNeeded { get; set; }
        public List<CommunityPartners> CommunityPartners { get; set; }
        public List<TeamMembers> TeamMembers { get; set;}
        public string MyRole { get; set; }

    }
}
