using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalAssessment.Data
{
    public class ContextClass :DbContext
    {

        public ContextClass(DbContextOptions<ContextClass> options) : base(options)
        {
        }

        public DbSet<FinalAssessment.Models.Bank> Banks { get; set; }

        public DbSet<FinalAssessment.Models.Customer> Cutomers { get; set; }
        public DbSet<FinalAssessment.Models.Tag> Tags { get; set; }

    }
}
