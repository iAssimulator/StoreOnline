using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class SalesPerson
    {
        public SalesPerson()
        {
            this.SalesPersonQuotaHistories = new List<SalesPersonQuotaHistory>();
        }

        public int SalesPersonID { get; set; }
        public int? TerritoryID { get; set; }
        public decimal? SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYTD { get; set; }
        public decimal SalesLastYear { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
    }
}
