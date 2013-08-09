using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressID);

            // Properties
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

            // Table & Column Mappings
            this.ToTable("Address", "Person");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.AddressLine1).HasColumnName("AddressLine1");
            this.Property(t => t.AddressLine2).HasColumnName("AddressLine2");
            this.Property(t => t.Town).HasColumnName("Town");
            this.Property(t => t.CountyID).HasColumnName("CountyID");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.CountryID);
            this.HasRequired(t => t.County)
                .WithMany(t => t.Addresses)
                .HasForeignKey(d => d.CountyID);

        }
    }
}
