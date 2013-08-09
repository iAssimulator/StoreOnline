using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class SpecialOfferMap : EntityTypeConfiguration<SpecialOffer>
    {
        public SpecialOfferMap()
        {
            // Primary Key
            this.HasKey(t => t.SpecialOfferID);

            // Properties
            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("SpecialOffer", "Sales");
            this.Property(t => t.SpecialOfferID).HasColumnName("SpecialOfferID");
            this.Property(t => t.SpecialOfferTypeID).HasColumnName("SpecialOfferTypeID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DiscountPct).HasColumnName("DiscountPct");
            this.Property(t => t.CategoryPick).HasColumnName("CategoryPick");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.MinQty).HasColumnName("MinQty");
            this.Property(t => t.MaxQty).HasColumnName("MaxQty");
            this.Property(t => t.rowguid).HasColumnName("rowguid");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
