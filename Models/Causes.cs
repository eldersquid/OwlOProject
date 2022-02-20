using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    public class Causes
    {
        [Key]
        public string Causes_id { get; set; }
        public string Cause { get; set; }
        public string Project_ID { get; set; }
    }
}
