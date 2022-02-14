using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class Owlee
    {
        [Required,Key,DatabaseGenerated(DatabaseGeneratedOption.None),DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string NRIC { get; set; }

        [Required, MaxLength(25)]
        public string Name { get; set; }

        [Required,MaxLength(1)]
        public string Gender { get; set; }

        public int Owl_Points { get; set; }



        [MaxLength(3000)]
        public string Bio { get; set; }

        [Required, MaxLength(100)]
        public string Citizenship { get; set; }

    }
}
