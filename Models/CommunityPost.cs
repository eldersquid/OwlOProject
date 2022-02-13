using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OwlOProjectA.Models
{
    public class CommunityPost
    {
        [Key]

        public string Id { get; set; }

        [Required]
        public string PostCaption  { get; set; }

        public string Image { get; set; }
    }
}
