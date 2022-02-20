using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    public class userSkills
    {
        [Key]
        public string userSkills_ID { get; set; }
        public string userSkill { get; set; }
        public string Project_ID { get; set; }
    }
}

