using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreManager.Core.Models;

namespace StoreManager.Infrastructure.Data.EntityFramework.Mapping
{
    public class PostCodeDataMap : EntityTypeConfiguration<PostCodeData>
    {
        public PostCodeDataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OutwardCode, t.InwardCode });

            // Properties
            this.Property(t => t.OutwardCode)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.InwardCode)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("PostCodeData", "OrdnanceSurvey");
            this.Property(t => t.OutwardCode).HasColumnName("OutwardCode");
            this.Property(t => t.InwardCode).HasColumnName("InwardCode");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.GeoLocation).HasColumnName("GeoLocation");
        }
    }
}
