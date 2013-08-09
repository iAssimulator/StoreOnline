using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class MemberRoleMap : EntityTypeConfiguration<MemberRole>
    {
        public MemberRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.MRO_ID);

            // Properties
            this.Property(t => t.MRO_RoleName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MRO_LoweredRoleName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MRO_Description)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("MemberRole", "Member");
            this.Property(t => t.MRO_ID).HasColumnName("MRO_ID");
            this.Property(t => t.MRO_RoleName).HasColumnName("MRO_RoleName");
            this.Property(t => t.MRO_LoweredRoleName).HasColumnName("MRO_LoweredRoleName");
            this.Property(t => t.MRO_Description).HasColumnName("MRO_Description");
        }
    }
}
