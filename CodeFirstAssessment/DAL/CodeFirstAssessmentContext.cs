using CodeFirstAssessment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CodeFirstAssessment.DAL
{
    public class CodeFirstAssessmentContext : DbContext
    {
        public CodeFirstAssessmentContext() : base("CodeFirstAssessmentContext")
        {
        }

        public DbSet<Insuree> Insurees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}