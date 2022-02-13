using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class LuckyDraw
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string LuckyDraw_ID { get; set; }

        [Required, MaxLength(100)]
        public string LuckyDraw_Name { get; set; }

        [Required, MaxLength(50)]
        public string LuckyDraw_Company { get; set; }

        [Required]
        public int LuckyDraw_Cost { get; set; }

        [Required]
        public int LuckyDraw_Quantity { get; set; }

        [Required, MaxLength(3000)]
        public string LuckyDraw_Description { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime LuckyDraw_Expiry { get; set; }

        



        
    }
}
