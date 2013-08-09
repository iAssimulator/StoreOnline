using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class OrderStateMap : EntityTypeConfiguration<OrderState>
    {
        public OrderStateMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderStatusID);

            // Properties
            this.Property(t => t.StatusName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrderState", "Purchasing");
            this.Property(t => t.OrderStatusID).HasColumnName("OrderStatusID");
            this.Property(t => t.StatusName).HasColumnName("StatusName");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
