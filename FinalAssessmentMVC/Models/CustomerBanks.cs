using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssessmentMVC.Models
{
    public class CustomerBanks
    {
        [Key]
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string BankName { get; set; }

        public int TagId { get; set; }
    }
}
