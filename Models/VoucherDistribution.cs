using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class VoucherDistribution
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string VoucherDistribution_ID { get; set; }

        [Required, MaxLength(100)]
        public string VoucherDistribution_VoucherID { get; set; }

        [Required]
        public string VoucherDistribution_OwnerEmail { get; set; }

        [Required, MaxLength(100)]
        public string VoucherDistribution_VoucherName { get; set; }

        [Required]
        public int VoucherDistribution_VoucherCost { get; set; }
        
        [Required, DataType(DataType.Date)]
        public DateTime VoucherDistribution_VoucherExpiry { get; set; }

        public bool VoucherDistribution_VoucherSuperDeal { get; set; }
        
        [Required, MaxLength(50)]
        public string VoucherDistribution_VoucherCompany { get; set; }

    }
}
