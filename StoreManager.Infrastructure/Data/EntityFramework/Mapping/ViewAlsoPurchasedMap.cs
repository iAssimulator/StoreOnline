using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreManager.Core.Models;

namespace StoreManager.Infrastructure.Data.EntityFramework.Mapping
{
    public class ViewAlsoPurchasedMap : EntityTypeConfiguration<ViewAlsoPurchased>
    {
        public ViewAlsoPurchasedMap()
        {
            // Primary Key
            this.HasKey(t => t.Products_ProductID);

            // Properties
            this.Property(t => t.ProductName)
                .HasMaxLength(50);

            this.Property(t => t.Products_ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ViewAlsoPurchased");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.TotalNumPurchased).HasColumnName("TotalNumPurchased");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Products_ProductID).HasColumnName("Products_ProductID");
        }
    }
}
