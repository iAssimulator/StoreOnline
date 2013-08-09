using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using StoreOnline.Core.Models;

namespace StoreOnline.Infrastructure.Data.EntityFramework.Mapping
{
    public class ProductReviewMap : EntityTypeConfiguration<ProductReview>
    {
        public ProductReviewMap()
        {
            // Primary Key
            this.HasKey(t => t.ReviewID);

            // Properties
            this.Property(t => t.CustomerName)
                .HasMaxLength(50);

            this.Property(t => t.CustomerEmail)
                .HasMaxLength(50);

            this.Property(t => t.Comments)
                .HasMaxLength(900);

            // Table & Column Mappings
            this.ToTable("ProductReview", "Production");
            this.Property(t => t.ReviewID).HasColumnName("ReviewID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.CustomerEmail).HasColumnName("CustomerEmail");
            this.Property(t => t.Rating).HasColumnName("Rating");
            this.Property(t => t.Comments).HasColumnName("Comments");
        }
    }
}
