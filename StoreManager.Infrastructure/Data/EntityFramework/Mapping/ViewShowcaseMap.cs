using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreManager.Core.Models;

namespace StoreManager.Infrastructure.Data.EntityFramework.Mapping
{
    public class ViewShowcaseMap : EntityTypeConfiguration<ViewShowcase>
    {
        public ViewShowcaseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductID, t.ProductNumber, t.Discountinued, t.ShowCase, t.Promo_A, t.Promo_B });

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ProductName)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(3800);

            this.Property(t => t.PhotoPath)
                .HasMaxLength(50);

            this.Property(t => t.ProductCode)
                .IsFixedLength()
                .HasMaxLength(13);

            // Table & Column Mappings
            this.ToTable("ViewShowcase");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductNumber).HasColumnName("ProductNumber");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.UnitsInStock).HasColumnName("UnitsInStock");
            this.Property(t => t.UnitsOnOrder).HasColumnName("UnitsOnOrder");
            this.Property(t => t.ReorderLevel).HasColumnName("ReorderLevel");
            this.Property(t => t.Discountinued).HasColumnName("Discountinued");
            this.Property(t => t.PhotoPath).HasColumnName("PhotoPath");
            this.Property(t => t.ShowCase).HasColumnName("ShowCase");
            this.Property(t => t.Promo_A).HasColumnName("Promo_A");
            this.Property(t => t.Promo_B).HasColumnName("Promo_B");
            this.Property(t => t.ProductCode).HasColumnName("ProductCode");
        }
    }
}
