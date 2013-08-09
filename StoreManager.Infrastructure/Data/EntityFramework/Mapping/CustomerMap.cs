using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerID);

            // Properties
            this.Property(t => t.Gender)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Customer", "Sales");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.ContactID).HasColumnName("ContactID");
            this.Property(t => t.AddressID).HasColumnName("AddressID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.PhotoID).HasColumnName("PhotoID");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.MemberUser)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.UserID);
            this.HasRequired(t => t.Contact)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.ContactID);

        }
    }
}
