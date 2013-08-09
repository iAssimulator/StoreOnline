using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class CreditCardTypeMap : EntityTypeConfiguration<CreditCardType>
    {
        public CreditCardTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CreditCardTypeID);

            // Properties
            this.Property(t => t.CardType)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CreditCardType", "Sales");
            this.Property(t => t.CreditCardTypeID).HasColumnName("CreditCardTypeID");
            this.Property(t => t.CardType).HasColumnName("CardType");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
