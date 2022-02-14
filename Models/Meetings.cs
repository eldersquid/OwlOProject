using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    public class Meetings
    {
        [Key]
        public string Meeting_ID { get; set; }
        public string Project_ID { get; set; }
        public string Meeting_Caller { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int priority { get; set; }
        public string platform_link { get; set; }

    }
}
