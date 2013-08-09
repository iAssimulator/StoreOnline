using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class Product
    {
        public Product()
        {
            this.ProductProductPhotoes = new List<ProductProductPhoto>();
            this.SpecialOfferProducts = new List<SpecialOfferProduct>();
        }

        public int ProductID { get; set; }
        public string ProductNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short SafetyStockLevel { get; set; }
        public short ReorderPoint { get; set; }
        public decimal StandardCost { get; set; }
        public decimal ListPrice { get; set; }
        public int DaysToManufacture { get; set; }
        public int? CategoryID { get; set; }
        public int? SupplierID { get; set; }
        public int? PhotoID { get; set; }
        public System.DateTime SellStartDate { get; set; }
        public DateTime? SellEndDate { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Craftman Craftman { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductPhoto ProductPhoto { get; set; }
        public virtual ICollection<ProductProductPhoto> ProductProductPhotoes { get; set; }
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }
    }
}
