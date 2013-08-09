using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class SalesOrderHeaderMap : EntityTypeConfiguration<SalesOrderHeader>
    {
        public SalesOrderHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.SalesOrderID);

            // Properties
            this.Property(t => t.SalesOrderNumber)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.CreditCardApprovalCode)
                .HasMaxLength(15);

            this.Property(t => t.Comment)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("SalesOrderHeader", "Sales");
            this.Property(t => t.SalesOrderID).HasColumnName("SalesOrderID");
            this.Property(t => t.RevisionNumber).HasColumnName("RevisionNumber");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.DueDate).HasColumnName("DueDate");
            this.Property(t => t.ShipDate).HasColumnName("ShipDate");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
            this.Property(t => t.OnlineOrderFlag).HasColumnName("OnlineOrderFlag");
            this.Property(t => t.SalesOrderNumber).HasColumnName("SalesOrderNumber");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.ContactID).HasColumnName("ContactID");
            this.Property(t => t.SalesPersonID).HasColumnName("SalesPersonID");
            this.Property(t => t.BillToAddressID).HasColumnName("BillToAddressID");
            this.Property(t => t.ShipToAddressID).HasColumnName("ShipToAddressID");
            this.Property(t => t.ShipMethodID).HasColumnName("ShipMethodID");
            this.Property(t => t.CreditCardID).HasColumnName("CreditCardID");
            this.Property(t => t.CreditCardApprovalCode).HasColumnName("CreditCardApprovalCode");
            this.Property(t => t.CurrencyRateID).HasColumnName("CurrencyRateID");
            this.Property(t => t.SubTotal).HasColumnName("SubTotal");
            this.Property(t => t.Freight).HasColumnName("Freight");
            this.Property(t => t.TotalDue).HasColumnName("TotalDue");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Address)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.BillToAddressID);
            this.HasRequired(t => t.Address1)
                .WithMany(t => t.SalesOrderHeaders1)
                .HasForeignKey(d => d.ShipToAddressID);
            this.HasRequired(t => t.Contact)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.ContactID);
            this.HasRequired(t => t.OrderState)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.StatusID);
            this.HasRequired(t => t.ShipMethod)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.ShipMethodID);
            this.HasOptional(t => t.CreditCard)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.CreditCardID);
            this.HasOptional(t => t.CurrencyRate)
                .WithMany(t => t.SalesOrderHeaders)
                .HasForeignKey(d => d.CurrencyRateID);

        }
    }
}
