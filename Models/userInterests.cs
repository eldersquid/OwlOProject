using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    public class userInterests
    {
        [Key]
        public string userInterest_ID { get; set; }
        public string interest { get; set; }
        public string Project_ID { get; set; }
    }
}
