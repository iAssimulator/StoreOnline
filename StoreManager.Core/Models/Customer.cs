using System;

namespace StoreOnline.Core.Models
{
    public partial class Customer
    {
        public int CustomerID { get; set; }
        public int ContactID { get; set; }
        public int AddressID { get; set; }
        public int? UserID { get; set; }
        public int? PhotoID { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public DateTime ModifiedDate { get; set; }
        public virtual MemberUser MemberUser { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
