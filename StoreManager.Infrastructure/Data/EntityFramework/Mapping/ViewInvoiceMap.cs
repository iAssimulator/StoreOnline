using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreManager.Core.Models;

namespace StoreManager.Infrastructure.Data.EntityFramework.Mapping
{
    public class ViewInvoiceMap : EntityTypeConfiguration<ViewInvoice>
    {
        public ViewInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            this.Property(t => t.ShipName)
                .HasMaxLength(50);

            this.Property(t => t.ShipAddress)
                .HasMaxLength(60);

            this.Property(t => t.ShipCity)
                .HasMaxLength(15);

            this.Property(t => t.ShipPostalCode)
                .HasMaxLength(10);

            this.Property(t => t.ShipCountry)
                .HasMaxLength(20);

            this.Property(t => t.UserName)
                .HasMaxLength(256);

            this.Property(t => t.CustomerName)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(60);

            this.Property(t => t.City)
                .HasMaxLength(13);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .HasMaxLength(20);

            this.Property(t => t.Salesperson)
                .HasMaxLength(51);

            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShipperName)
                .HasMaxLength(40);

            this.Property(t => t.ProductName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ViewInvoice");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.ShipAddress).HasColumnName("ShipAddress");
            this.Property(t => t.ShipCity).HasColumnName("ShipCity");
            this.Property(t => t.ShipPostalCode).HasColumnName("ShipPostalCode");
            this.Property(t => t.ShipCountry).HasColumnName("ShipCountry");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Salesperson).HasColumnName("Salesperson");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.ShippedDate).HasColumnName("ShippedDate");
            this.Property(t => t.ShipperName).HasColumnName("ShipperName");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.ExtendedPrice).HasColumnName("ExtendedPrice");
            this.Property(t => t.Freight).HasColumnName("Freight");
        }
    }
}
