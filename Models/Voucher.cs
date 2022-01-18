using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class Voucher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Vouchers_ID { get; set; }

        [Required, MaxLength(100)]
        public string Voucher_Name { get; set; }

        [Required, MaxLength(50)]
        public string Voucher_Company { get; set; }

        

        [Required]
        public int Voucher_Cost { get; set; }

        [Required, MaxLength(3000)]
        public string Voucher_Description { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime Voucher_Expiry { get; set; }
        
        public bool Super_Deal { get; set; }

        public double DiscountDeal_Percentage { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Inventory_ID { get; set; }

        
    }
}
