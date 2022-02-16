using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class Venue
    {
        [Key]
        public int Venue_ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Weekdays { get; set; }

        [Required]
        public string Weekends { get; set; }
    }
}
