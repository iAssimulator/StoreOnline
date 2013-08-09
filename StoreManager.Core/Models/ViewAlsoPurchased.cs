using System;
using System.Collections.Generic;

namespace StoreManager.Infrastructure.Models
{
    public partial class ViewAlsoPurchased
    {
        public Nullable<int> ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> TotalNumPurchased { get; set; }
        public Nullable<int> OrderID { get; set; }
        public int Products_ProductID { get; set; }
    }
}
