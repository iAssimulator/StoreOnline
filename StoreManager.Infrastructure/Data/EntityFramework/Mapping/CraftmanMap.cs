using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class CraftmanMap : EntityTypeConfiguration<Craftman>
    {
        public CraftmanMap()
        {
            // Primary Key
            this.HasKey(t => t.CraftID);

            // Properties
            this.Property(t => t.CompanyName)
                .HasMaxLength(50);

            this.Property(t => t.ContactName)
                .HasMaxLength(40);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.BusinessPhone)
                .HasMaxLength(24);

            this.Property(t => t.MobilePhone)
                .HasMaxLength(24);

            this.Property(t => t.Fax)
                .HasMaxLength(24);

            this.Property(t => t.Notes)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("Craftman", "Supplies");
            this.Property(t => t.CraftID).HasColumnName("CraftID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.BusinessPhone).HasColumnName("BusinessPhone");
            this.Property(t => t.MobilePhone).HasColumnName("MobilePhone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.Notes).HasColumnName("Notes");

            // Relationships
            this.HasRequired(t => t.Address)
                .WithMany(t => t.Craftmen)
                .HasForeignKey(d => d.AddressID);

        }
    }
}
