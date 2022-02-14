using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    public class JoinRequests
    {
        [Key]
        public string JoinRequest_id { get; set; }
        public string User { get; set; }
        public string Introduction { get; set; }
        public string Reason { get; set; }
        public string Feedback { get; set; }
        public string Project_ID { get; set; }
    }
}
