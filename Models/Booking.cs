using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class Booking
    {
        [Key]
        public int Booking_ID { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public int workshopID { get; set; }

        [Required]
        public int venueID { get; set; }

    }
}
