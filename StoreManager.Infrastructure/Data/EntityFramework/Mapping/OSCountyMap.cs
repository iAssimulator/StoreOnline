using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreManager.Core.Models;

namespace StoreManager.Infrastructure.Data.EntityFramework.Mapping
{
    public class OSCountyMap : EntityTypeConfiguration<OSCounty>
    {
        public OSCountyMap()
        {
            // Primary Key
            this.HasKey(t => t.Code);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("OSCounty", "OrdnanceSurvey");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
