using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductNumber)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(800);

            this.Property(t => t.Color)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Product", "Production");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductNumber).HasColumnName("ProductNumber");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Color).HasColumnName("Color");
            this.Property(t => t.UnitsInStock).HasColumnName("UnitsInStock");
            this.Property(t => t.UnitsOnOrder).HasColumnName("UnitsOnOrder");
            this.Property(t => t.SafetyStockLevel).HasColumnName("SafetyStockLevel");
            this.Property(t => t.ReorderPoint).HasColumnName("ReorderPoint");
            this.Property(t => t.StandardCost).HasColumnName("StandardCost");
            this.Property(t => t.ListPrice).HasColumnName("ListPrice");
            this.Property(t => t.DaysToManufacture).HasColumnName("DaysToManufacture");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.PhotoID).HasColumnName("PhotoID");
            this.Property(t => t.SellStartDate).HasColumnName("SellStartDate");
            this.Property(t => t.SellEndDate).HasColumnName("SellEndDate");
            this.Property(t => t.DiscontinuedDate).HasColumnName("DiscontinuedDate");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasOptional(t => t.Craftman)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.SupplierID);
            this.HasOptional(t => t.ProductCategory)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CategoryID);
            this.HasOptional(t => t.ProductPhoto)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.PhotoID);

        }
    }
}
