using System;
using System.Collections.Generic;

namespace StoreManager.Infrastructure.Models
{
    public partial class ViewCart
    {
        public int ProductID { get; set; }
        public System.Guid ProductNumber { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string CartID { get; set; }
    }
}
