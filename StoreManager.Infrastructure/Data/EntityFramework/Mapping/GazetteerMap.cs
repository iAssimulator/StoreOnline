using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreManager.Core.Models;

namespace StoreManager.Infrastructure.Data.EntityFramework.Mapping
{
    public class GazetteerMap : EntityTypeConfiguration<Gazetteer>
    {
        public GazetteerMap()
        {
            // Primary Key
            this.HasKey(t => t.SeqNo);

            // Properties
            this.Property(t => t.SeqNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PlaceName)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.CountyCode)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.FeatureCode)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("Gazetteer", "OrdnanceSurvey");
            this.Property(t => t.SeqNo).HasColumnName("SeqNo");
            this.Property(t => t.PlaceName).HasColumnName("PlaceName");
            this.Property(t => t.CountyCode).HasColumnName("CountyCode");
            this.Property(t => t.FeatureCode).HasColumnName("FeatureCode");
            this.Property(t => t.Longitude).HasColumnName("Longitude");
            this.Property(t => t.Latitude).HasColumnName("Latitude");
            this.Property(t => t.GeoLocation).HasColumnName("GeoLocation");

            // Relationships
            this.HasRequired(t => t.Feature)
                .WithMany(t => t.Gazetteers)
                .HasForeignKey(d => d.FeatureCode);
            this.HasRequired(t => t.OSCounty)
                .WithMany(t => t.Gazetteers)
                .HasForeignKey(d => d.CountyCode);

        }
    }
}
