using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Models
{
    public class Comment
    {
     [Key]
        public string Id { get; set; }

        public string User_Comment { get; set; }

        public string Name { get; set; }

       
    }
}
