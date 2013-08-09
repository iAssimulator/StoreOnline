using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class Currency
    {
        public Currency()
        {
            this.CurrencyRates = new List<CurrencyRate>();
            this.CurrencyRates1 = new List<CurrencyRate>();
        }

        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRates { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRates1 { get; set; }
    }
}
