using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace owlo_plan.Models
{
    [Table("Owlers")]
    public class Owlers
    {
        [Key]
        public string Email { get; set; }
        public string username { get; set; }
        public string bio { get; set; }
    }
}
