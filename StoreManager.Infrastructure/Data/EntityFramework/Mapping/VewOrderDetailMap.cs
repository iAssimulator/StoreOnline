using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreManager.Core.Models;

namespace StoreManager.Infrastructure.Data.EntityFramework.Mapping
{
    public class VewOrderDetailMap : EntityTypeConfiguration<VewOrderDetail>
    {
        public VewOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.ProductNumber });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VewOrderDetails");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductNumber).HasColumnName("ProductNumber");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
        }
    }
}
