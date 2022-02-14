using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    [Table("ProjectTasks")]
    public class ProjectTasks
    {
        [Key]
        public string ProjectTasks_ID { get; set; }
        [Required(ErrorMessage ="Task Cannot be empty")]
        public string task { get; set;}
        public string owner { get; set;}
        public DateTime timestamp { get; set; }
        public string Project_ID { get; set;}
    }
}
