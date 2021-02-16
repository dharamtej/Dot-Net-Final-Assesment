using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssessmentMVC.Models
{
    [Table("Banks")]
    public class Bank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required]
        public int BankId { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string BankAddress { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
