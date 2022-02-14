using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    public class CommunityPartners
    {
        [Key]
        public string CommunityPartners_ID { get; set; }
        public string CommunityPartner { get; set; }
        public string Project_ID { get; set; }
    }
}
