using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class PhotoMap : EntityTypeConfiguration<Photo>
    {
        public PhotoMap()
        {
            // Primary Key
            this.HasKey(t => t.PhotoID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Photo", "Person");
            this.Property(t => t.PhotoID).HasColumnName("PhotoID");
            this.Property(t => t.Avatar).HasColumnName("Avatar");
            this.Property(t => t.MainPhoto).HasColumnName("MainPhoto");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
