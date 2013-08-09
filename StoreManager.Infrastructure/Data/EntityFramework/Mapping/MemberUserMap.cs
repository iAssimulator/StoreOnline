using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class MemberUserMap : EntityTypeConfiguration<MemberUser>
    {
        public MemberUserMap()
        {
            // Primary Key
            this.HasKey(t => t.MUS_ID);

            // Properties
            this.Property(t => t.MUS_Login)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MUS_LoweredLogin)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MUS_Password)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.MUS_Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MUS_LoweredEmail)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MUS_UserAgent)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("MemberUser", "Member");
            this.Property(t => t.MUS_ID).HasColumnName("MUS_ID");
            this.Property(t => t.MUS_Login).HasColumnName("MUS_Login");
            this.Property(t => t.MUS_LoweredLogin).HasColumnName("MUS_LoweredLogin");
            this.Property(t => t.MUS_Password).HasColumnName("MUS_Password");
            this.Property(t => t.MUS_Email).HasColumnName("MUS_Email");
            this.Property(t => t.MUS_LoweredEmail).HasColumnName("MUS_LoweredEmail");
            this.Property(t => t.MUS_RoleID).HasColumnName("MUS_RoleID");
            this.Property(t => t.MUS_Token).HasColumnName("MUS_Token");
            this.Property(t => t.MUS_TokenCreatedAt).HasColumnName("MUS_TokenCreatedAt");
            this.Property(t => t.MUS_TokenExpiresAt).HasColumnName("MUS_TokenExpiresAt");
            this.Property(t => t.MUS_UserAgent).HasColumnName("MUS_UserAgent");

            // Relationships
            this.HasRequired(t => t.MemberRole)
                .WithMany(t => t.MemberUsers)
                .HasForeignKey(d => d.MUS_RoleID);

        }
    }
}
