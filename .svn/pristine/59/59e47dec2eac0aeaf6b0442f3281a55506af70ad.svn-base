using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            this.Products = new List<Product>();
        }

        public int ProductCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
