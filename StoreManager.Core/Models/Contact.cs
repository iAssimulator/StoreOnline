using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class Contact
    {
        public Contact()
        {
            this.Employees = new List<Employee>();
            this.ContactCreditCards = new List<ContactCreditCard>();
            this.Customers = new List<Customer>();
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

        public int ContactID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string ShortName { get; set; }
        public int EmailPromotion { get; set; }
        public string Phone { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<ContactCreditCard> ContactCreditCards { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
