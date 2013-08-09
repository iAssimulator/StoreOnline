using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class ShoppingBasketItemMap : EntityTypeConfiguration<ShoppingBasketItem>
    {
        public ShoppingBasketItemMap()
        {
            // Primary Key
            this.HasKey(t => t.RecordID);

            // Properties
            this.Property(t => t.BasketID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ShoppingBasketItem", "Sales");
            this.Property(t => t.RecordID).HasColumnName("RecordID");
            this.Property(t => t.BasketID).HasColumnName("BasketID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
        }
    }
}
