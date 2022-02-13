using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class Community
    {
        [Key]

        public string Id { get; set; }

        [Required]
        public string ComName { get; set; }

        [Required]

        public string ComDescp { get; set; }

        public string Image { get; set; }

    }
}
