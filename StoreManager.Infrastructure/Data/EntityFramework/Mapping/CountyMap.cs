using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class CountyMap : EntityTypeConfiguration<County>
    {
        public CountyMap()
        {
            // Primary Key
            this.HasKey(t => t.CountyID);

            // Properties
            this.Property(t => t.CountyName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("County", "Location");
            this.Property(t => t.CountyID).HasColumnName("CountyID");
            this.Property(t => t.CountyName).HasColumnName("CountyName");
            this.Property(t => t.CountyCountryID).HasColumnName("CountyCountryID");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.Counties)
                .HasForeignKey(d => d.CountyCountryID);

        }
    }
}
