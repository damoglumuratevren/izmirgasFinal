using System;
using System.Collections.Generic;
using System.Text;
using IzmirGaz.Data.Concrete.EntityFremework.Mappings;
using IzmirGaz.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace IzmirGaz.Data.Concrete.EntityFremework.Contexts
{
   public class IzmirGazContext:DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyPersonnel> CompanyPersonnels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-HJD0L7Q\SQLEXPRESS;Database=IzmirGaz;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyMap());
            modelBuilder.ApplyConfiguration(new CompanyPersonnelMap());
        }
    }
}
