using System;
using System.Collections.Generic;
using StoreOnline.Core.Models;

namespace StoreOnline.Core.Models
{
    public partial class Country
    {
        public Country()
        {
            this.Addresses = new List<Address>();
            this.Counties = new List<County>();
        }

        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<County> Counties { get; set; }
    }
}
