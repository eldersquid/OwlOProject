using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace owlo_plan.Models
{
    [Table("Projects")]
    public class Projects
    {
        [Key]
        public string Project_ID { get; set; }
        public string Owner { get; set; }
        //title, description, image, members
        [Required(ErrorMessage="Title Is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description Is required")]
        public string Description { get; set; }
        //http://www.binaryintellect.net/articles/2f55345c-1fcb-4262-89f4-c4319f95c5bd.aspx
        [Required(ErrorMessage = "Image is required")]
        public string Image { get; set; }
        public string Members { get; set; }
        public Boolean Published { get; set; }

        
    }
}
