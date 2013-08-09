using System;
using System.Collections.Generic;
using StoreOnline.Core.Models;

namespace StoreOnline.Core.Models
{
    public partial class Craftman
    {
        public Craftman()
        {
            this.Products = new List<Product>();
        }

        public int CraftID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string BusinessPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public int AddressID { get; set; }
        public string Notes { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
