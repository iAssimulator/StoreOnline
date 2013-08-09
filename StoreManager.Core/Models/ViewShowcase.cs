using System;
using System.Collections.Generic;

namespace StoreManager.Infrastructure.Models
{
    public partial class ViewShowcase
    {
        public int ProductID { get; set; }
        public System.Guid ProductNumber { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discountinued { get; set; }
        public string PhotoPath { get; set; }
        public bool ShowCase { get; set; }
        public bool Promo_A { get; set; }
        public bool Promo_B { get; set; }
        public string ProductCode { get; set; }
    }
}
