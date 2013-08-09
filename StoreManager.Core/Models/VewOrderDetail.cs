using System;
using System.Collections.Generic;

namespace StoreManager.Infrastructure.Models
{
    public partial class VewOrderDetail
    {
        public int ProductID { get; set; }
        public System.Guid ProductNumber { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> OrderID { get; set; }
    }
}
