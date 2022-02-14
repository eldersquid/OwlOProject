using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Models
{
    public class OwlerWithAttributes
    {
        public Owlers owler { get; set; }
        public List<userSkills> userskills{get;set;}
        public List<userInterests> userInterests { get; set; }

    }
}
