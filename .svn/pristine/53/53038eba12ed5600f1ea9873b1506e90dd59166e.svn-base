using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class OrderState
    {
        public OrderState()
        {
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public int OrderStatusID { get; set; }
        public string StatusName { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
