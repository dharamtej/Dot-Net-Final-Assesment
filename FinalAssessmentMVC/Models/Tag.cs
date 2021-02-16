using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssessmentMVC.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int TagId { get; set; }
        [Required]
        public int BankId { get; set; }

        [ForeignKey("BankId")]
        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        [Required]
        public decimal Balance { get; set; }

        public Bank Bank { get; set; }
        public Customer Customer { get; set; }
    }
}
