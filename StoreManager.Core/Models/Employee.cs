using System;

namespace StoreOnline.Core.Models
{
    public partial class Employee
    {
        public int EmployeeID { get; set; }
        public string NationalIDNumber { get; set; }
        public int ContactID { get; set; }
        public int AddressID { get; set; }
        public int? UserID { get; set; }
        public string Title { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public System.DateTime HireDate { get; set; }
        public bool SalariedFlag { get; set; }
        public short HolidayHours { get; set; }
        public short SickLeaveHours { get; set; }
        public bool CurrentFlag { get; set; }
        public int? PhotoID { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual MemberUser MemberUser { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
