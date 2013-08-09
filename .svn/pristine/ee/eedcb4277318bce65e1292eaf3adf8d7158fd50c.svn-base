using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class vEmployeeMap : EntityTypeConfiguration<vEmployee>
    {
        public vEmployeeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeID, t.FirstName, t.LastName, t.JobTitle, t.EmailPromotion, t.AddressLine1, t.Town, t.PostalCode, t.CountyName, t.CountryName });

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .HasMaxLength(8);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MiddleName)
                .HasMaxLength(50);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Suffix)
                .HasMaxLength(10);

            this.Property(t => t.JobTitle)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(15);

            this.Property(t => t.Email)
                .HasMaxLength(256);

            this.Property(t => t.EmailPromotion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddressLine1)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.AddressLine2)
                .HasMaxLength(60);

            this.Property(t => t.Town)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.PostalCode)
                .IsRequired()
                .HasMaxLength(9);

            this.Property(t => t.CountyName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CountryName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("vEmployee", "HumanResources");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.MiddleName).HasColumnName("MiddleName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Suffix).HasColumnName("Suffix");
            this.Property(t => t.JobTitle).HasColumnName("JobTitle");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.EmailPromotion).HasColumnName("EmailPromotion");
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
            this.Property(t => t.Town).HasColumnName("Town");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.CountyName).HasColumnName("CountyName");
            this.Property(t => t.CountryName).HasColumnName("CountryName");
            this.Property(t => t.Avatar).HasColumnName("Avatar");
            this.Property(t => t.MainPhoto).HasColumnName("MainPhoto");
        }
    }
}
