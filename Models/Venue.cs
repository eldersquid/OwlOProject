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
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Mon { get; set; }

        [Required]
        public string Tue { get; set; }

        [Required]
        public string Wed { get; set; }

        [Required]
        public string Thu { get; set; }

        [Required]
        public string Fri { get; set; }

        [Required]
        public string Sat { get; set; }

        [Required]
        public string Sun { get; set; }
    }
}
