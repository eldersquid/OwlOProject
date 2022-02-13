using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class FAQ
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string FAQ_ID { get; set; }

        [Required, MaxLength(100)]
        public string FAQ_Title { get; set; }

        public string FAQ_ImagePath { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime FAQ_DatePublished { get; set; }

        [Required]
        public string FAQ_Type { get; set; }

        [Required]

        public string FAQ_Content { get; set; }

        [MaxLength(100)]
        public string FAQ_Author { get; set; }


    }
}
