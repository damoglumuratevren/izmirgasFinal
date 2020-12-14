using System;
using System.Collections.Generic;
using System.Text;
using IzmirGaz.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IzmirGaz.Data.Concrete.EntityFremework.Mappings
{
    public class CompanyMap:IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.CompanyName).HasMaxLength(250);
            builder.Property(c => c.CompanyName).IsRequired();
            
            builder.Property(c => c.Address).IsRequired();
            builder.Property(c => c.Address).HasMaxLength(300);
            
            builder.Property(c => c.VisaDuration).IsRequired();

            builder.Property(c => c.CompanyCertificateEndDate).IsRequired();

            builder.Property(c => c.CompanyPhoneNumber).HasMaxLength(15);
            builder.Property(c => c.CompanyPhoneNumber).IsRequired();
            builder.HasIndex(c => c.CompanyPhoneNumber).IsUnique();

            builder.Property(c => c.CompanyCountry).HasMaxLength(50);
            builder.Property(c => c.CompanyCountry).IsRequired();

            builder.Property(c => c.Email).HasMaxLength(150);
            builder.Property(c => c.Email).IsRequired();
            builder.HasIndex(c => c.Email).IsUnique();

            builder.Property(c => c.CompanyManagerFirstName).IsRequired();
            builder.Property(c => c.CompanyManagerFirstName).HasMaxLength(75);


            builder.Property(c => c.CompanyManagerLastName).IsRequired();
            builder.Property(c => c.CompanyManagerLastName).HasMaxLength(75);

            builder.Property(c => c.CompanyManagerPhoneNumber).HasMaxLength(15);
            builder.HasIndex(c => c.CompanyManagerPhoneNumber).IsUnique();

            builder.Property(c => c.CompanyPerformanceReport).IsRequired();
            builder.Property(c => c.PercentageOfGasFired).IsRequired();
            //default
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);

            builder.ToTable("Companies");

            builder.HasData(new Company
            {
                Id = 1,
                CompanyName = "Damoğlu Sıhhi Tesisat LTD ŞTI",
                Address = "Anafartalar Mah. Cebeci sok No:11",
                CompanyCountry="Ödemiş",
                CompanyCertificateEndDate=DateTime.Now.AddYears(2),
                VisaDuration = DateTime.Now.AddYears(1),
                CompanyPhoneNumber = "506 384 11 29",
                Email = "mevrend@gmail.com",
                CompanyManagerFirstName = "Murat Evren",
                CompanyManagerLastName = "DAMOĞLU",
                CompanyManagerPhoneNumber = "232 384 11 29",
                CompanyPerformanceReport = 78.78,
                PercentageOfGasFired = 84,
                //default
                IsActive = true,
                IsDeleted = true,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new Company
                {
                    Id = 2,
                    CompanyName = "Öz Sıhhi Tesisat LTD ŞTI",
                    Address = "MuratBey Mah. Cebeci sok No:11",
                    CompanyCountry = "Tire",
                    CompanyCertificateEndDate = DateTime.Now.AddYears(3),
                    VisaDuration = DateTime.Now.AddDays(-7),
                    CompanyPhoneNumber = "506 555 17 28",
                    Email = "ozsihhi@gmail.com",
                    CompanyManagerFirstName = "Hakan",
                    CompanyManagerLastName = "Ay",
                    CompanyManagerPhoneNumber = "232 384 55 99",
                    CompanyPerformanceReport = 99.01,
                    PercentageOfGasFired = 89.41,
                    //default
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "DefaultInsert",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "DefaultInsert",
                    ModifiedDate = DateTime.Now,
                    Note = "DefaultValue"
            }, new Company
            {
                Id = 3,
                CompanyName = "Nevzat Sıhhi Tesisat LTD ŞTI",
                Address = "Nevzat Mah. Cebeci sok No:11",
                VisaDuration = DateTime.Now.AddYears(1),
                CompanyCountry = "Bornova",
                CompanyCertificateEndDate = DateTime.Now.AddYears(5),
                CompanyPhoneNumber = "506 555 77 77",
                Email = "nevzat@gmail.com",
                CompanyManagerFirstName = "Nevzat",
                CompanyManagerLastName = "KadirAy",
                CompanyManagerPhoneNumber = "232 384 77 77",
                CompanyPerformanceReport = 56.78,
                PercentageOfGasFired = 80.91,
                //default
                IsActive = true,
                IsDeleted = true,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            });

        }
    }
}
