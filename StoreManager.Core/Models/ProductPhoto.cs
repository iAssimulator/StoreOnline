using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class ProductPhoto
    {
        public ProductPhoto()
        {
            this.Products = new List<Product>();
            this.ProductProductPhotoes = new List<ProductProductPhoto>();
        }

        public int ProductPhotoID { get; set; }
        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public byte[] LargePhoto { get; set; }
        public string LargePhotoFileName { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductProductPhoto> ProductProductPhotoes { get; set; }
    }
}
