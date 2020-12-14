using System;
using System.Collections.Generic;
using System.Text;
using IzmirGaz.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IzmirGaz.Data.Concrete.EntityFremework.Mappings
{
  public  class CompanyPersonnelMap:IEntityTypeConfiguration<CompanyPersonnel>
    {
        public void Configure(EntityTypeBuilder<CompanyPersonnel> builder)
        {
            builder.HasKey(cp => cp.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(cp => cp.FirstName).IsRequired();
            builder.Property(cp => cp.FirstName).HasMaxLength(50);

            builder.Property(cp => cp.LastName).IsRequired();
            builder.Property(cp => cp.LastName).HasMaxLength(50);


            builder.Property(cp => cp.PhoneNumber).HasMaxLength(15);
            builder.HasIndex(cp => cp.PhoneNumber).IsUnique();

            builder.Property(cp => cp.PersonelEmail).HasMaxLength(150);
            builder.HasIndex(cp => cp.PersonelEmail).IsUnique();

            builder.Property(cp => cp.PersonelType).IsRequired();
            builder.Property(cp => cp.PersonelType).HasMaxLength(50);

            builder.Property(cp => cp.PersonelImg).IsRequired();
            builder.Property(cp => cp.PersonelImg).HasMaxLength(350);

            //default
            builder.Property(cp => cp.ModifiedByName).IsRequired();
            builder.Property(cp => cp.ModifiedByName).HasMaxLength(50);
            builder.Property(cp => cp.CreatedByName).IsRequired();
            builder.Property(cp => cp.CreatedByName).HasMaxLength(50);
            builder.Property(cp => cp.CreatedDate).IsRequired();
            builder.Property(cp => cp.ModifiedDate).IsRequired();
            builder.Property(cp => cp.IsActive).IsRequired();
            builder.Property(cp => cp.IsDeleted).IsRequired();
            builder.Property(cp => cp.Note).HasMaxLength(500);

            builder.HasOne<Company>(cp => cp.Company).WithMany(c => c.CompanyPersonnels)
                .HasForeignKey(cp => cp.CompanyId);
            builder.ToTable("CompanyPersonnels");

            builder.HasData(new CompanyPersonnel
            {
                Id = 1,
                FirstName = "Delal Abdullatif",
                LastName = "Abzak",
                PhoneNumber = "555 000 00 00",
                PersonelType = "Mühendis",
                PersonelEmail="default@gmail.com",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 1,
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 2,
                FirstName = "Atahan",
                LastName = "Adanır",
                PhoneNumber = "555 000 00 01",
                PersonelType = "Tesisatcı",
                PersonelEmail = "default1@gmail.com",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 1,
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 3,
                FirstName = "Hacı Mehmet",
                LastName = "Adıgüzel",
                PhoneNumber = "555 000 00 02",
                PersonelType = "Tesisatcı",
                PersonelEmail = "default2@gmail.com",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 1,
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 4,
                FirstName = "Tutkum",
                LastName = "Ahmadı Asl",
                PhoneNumber = "555 000 00 03",
                PersonelType = "Tesisatcı",
                PersonelEmail = "default3@gmail.com",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 1,
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 5,
                FirstName = "Recep Ali Samet",
                LastName = "Akdoğan",
                PhoneNumber = "555 000 00 04",
                PersonelType = "Mühendis",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 2,
                PersonelEmail = "default4@gmail.com",
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 6,
                FirstName = "Ahmet Polat",
                LastName = "Aklar Çörekçi",
                PhoneNumber = "555 000 00 05",
                PersonelType = "Tesisatcı",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 2,
                PersonelEmail = "default5@gmail.com",
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 7,
                FirstName = "Ecem Hatice",
                LastName = "Akova",
                PhoneNumber = "555 000 00 06",
                PersonelType = "Tesisatcı",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 2,
                PersonelEmail = "default6@gmail.com",
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 8,
                FirstName = "Selinti",
                LastName = "Al",
                PhoneNumber = "555 000 00 07",
                PersonelType = "Tesisatcı",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 2,
                PersonelEmail = "default7@gmail.com",
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 9,
                FirstName = "Çisem",
                LastName = "Atok",
                PhoneNumber = "555 000 00 08",
                PersonelType = "Mühendis",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 3,
                PersonelEmail = "default8@gmail.com",
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 10,
                FirstName = "Saime",
                LastName = "Avıandı",
                PhoneNumber = "555 000 00 09",
                PersonelType = "Tesisatcı",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 3,
                PersonelEmail = "default9@gmail.com",
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 11,
                FirstName = "Alçiçek",
                LastName = "Bad",
                PhoneNumber = "555 000 00 10",
                PersonelType = "Tesisatcı",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 3,
                PersonelEmail = "default10@gmail.com",
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            }, new CompanyPersonnel
            {
                Id = 12,
                FirstName = "Mustafa Samed",
                LastName = "Beğenilmiş",
                PhoneNumber = "555 000 00 11",
                PersonelType = "Tesisatcı",
                PersonelImg = "https://icons.iconarchive.com/icons/praveen/minimal-outline/128/profile-icon.png",
                CompanyId = 3,
                PersonelEmail = "default11@gmail.com",
                //default
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "DefaultInsert",
                CreatedDate = DateTime.Now,
                ModifiedByName = "DefaultInsert",
                ModifiedDate = DateTime.Now,
                Note = "DefaultValue"
            });
        }
    }
}
