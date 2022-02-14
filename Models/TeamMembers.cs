using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    public class TeamMembers
    {
        [Key]
        public string TeamMember_ID { get; set; }
        public string UserName { get; set; }
        public string role { get; set; }
        public string Project_ID { get; set; }
    }
}
