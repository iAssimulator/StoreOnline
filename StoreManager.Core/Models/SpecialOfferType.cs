using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class SpecialOfferType
    {
        public int SpecialOfferTypeID { get; set; }
        public string Type { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
