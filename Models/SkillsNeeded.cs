using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    public class SkillsNeeded
    {
        [Key]
        public string SkillsNeeded_ID { get; set; }
        public string Skill { get; set; }
        public string Project_ID { get; set; }
    }
}
