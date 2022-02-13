using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OwlOProjectA.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        



        [PersonalData]
        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string NRIC { get; set; }

        [PersonalData]
        [Required, MaxLength(25)]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        

        [Required, MaxLength(1)]
        [PersonalData]
        [Column(TypeName = "nchar(1)")]
        public string Gender { get; set; }

        [Column(TypeName = "int")]
        [PersonalData]
        public int Owl_Points { get; set; }

        [Column(TypeName = "int")]
        [PersonalData]
        public int Age { get; set; }

        [MaxLength(3000)]
        [PersonalData]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Bio { get; set; }

        [Required, MaxLength(100)]
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Citizenship { get; set; }

        [PersonalData]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Inventory_ID { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Mentor_Email { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var authenticationType = "Put authentication type Here";
            var userIdentity = new ClaimsIdentity(await manager.GetClaimsAsync(this), authenticationType);

            // Add custom user claims here
            return userIdentity;
        }

       
    }
}
