using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class AddressType
    {
        public int AddressTypeID { get; set; }
        public string Name { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
