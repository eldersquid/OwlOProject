using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class Workshop
    {
        [Key]
        public int Workshop_ID { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Image { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public string Summary { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string ownerEmail { get; set; }

        public string venueID { get; set; }


    }

}
