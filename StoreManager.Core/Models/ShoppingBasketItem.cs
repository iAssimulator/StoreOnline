using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class ShoppingBasketItem
    {
        public int RecordID { get; set; }
        public string BasketID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}
