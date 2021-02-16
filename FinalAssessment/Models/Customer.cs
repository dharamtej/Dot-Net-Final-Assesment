using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssessment.Models
{
    [Table("Customers21")]
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }

        public ICollection<Tag> tags { get; set; }
    }
}
