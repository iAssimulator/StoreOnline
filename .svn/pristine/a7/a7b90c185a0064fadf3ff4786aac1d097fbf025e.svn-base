using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class ShipMethod
    {
        public ShipMethod()
        {
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public int ShipMethodID { get; set; }
        public string Name { get; set; }
        public decimal ShipBase { get; set; }
        public decimal ShipRate { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
