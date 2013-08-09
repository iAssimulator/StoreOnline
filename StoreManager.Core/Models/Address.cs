using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class Address
    {
        public Address()
        {
            this.Employees = new List<Employee>();
            this.Craftmen = new List<Craftman>();
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
            this.SalesOrderHeaders1 = new List<SalesOrderHeader>();
        }

        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town { get; set; }
        public int CountyID { get; set; }
        public string PostalCode { get; set; }
        public int CountryID { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Country Country { get; set; }
        public virtual County County { get; set; }
        public virtual ICollection<Craftman> Craftmen { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders1 { get; set; }
    }
}
