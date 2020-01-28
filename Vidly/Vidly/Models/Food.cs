using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Food
    {
        public int Id { get; set; }

         [Required]
        public string Name { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        [Display(Name="Precio al publico")]
        public float Price { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; set; }

        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
    }
}