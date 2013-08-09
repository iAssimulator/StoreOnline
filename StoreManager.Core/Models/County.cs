using System;
using System.Collections.Generic;
using StoreOnline.Core.Models;

namespace StoreOnline.Core.Models
{
    public partial class County
    {
        public County()
        {
            this.Addresses = new List<Address>();
        }

        public int CountyID { get; set; }
        public string CountyName { get; set; }
        public int CountyCountryID { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
