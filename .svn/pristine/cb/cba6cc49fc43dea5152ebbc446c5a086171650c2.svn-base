using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class SpecialOffer
    {
        public SpecialOffer()
        {
            this.SpecialOfferProducts = new List<SpecialOfferProduct>();
        }

        public int SpecialOfferID { get; set; }
        public int? SpecialOfferTypeID { get; set; }
        public string Description { get; set; }
        public decimal DiscountPct { get; set; }
        public short CategoryPick { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public short MinQty { get; set; }
        public short? MaxQty { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }
    }
}
