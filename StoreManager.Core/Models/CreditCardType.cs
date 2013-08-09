using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class CreditCardType
    {
        public int CreditCardTypeID { get; set; }
        public string CardType { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
