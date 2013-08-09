using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreManager.Core.Models;

namespace StoreManager.Infrastructure.Data.EntityFramework.Mapping
{
    public class ViewCartMap : EntityTypeConfiguration<ViewCart>
    {
        public ViewCartMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.ProductNumber, t.Quantity, t.CartID });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .HasMaxLength(50);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CartID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ViewCart");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductNumber).HasColumnName("ProductNumber");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.CartID).HasColumnName("CartID");
        }
    }
}
