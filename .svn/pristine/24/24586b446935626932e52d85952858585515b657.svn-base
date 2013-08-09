using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class SpecialOfferTypeMap : EntityTypeConfiguration<SpecialOfferType>
    {
        public SpecialOfferTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.SpecialOfferTypeID);

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SpecialOfferType", "Sales");
            this.Property(t => t.SpecialOfferTypeID).HasColumnName("SpecialOfferTypeID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
