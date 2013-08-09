using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreOnline.Core.Models.Enums;

namespace StoreOnline.Core.Models.DTOs
{
    public class EmployeeRegistrationDto : BaseEntity
    {
        public string JobTitle { get; set; }
        public DateTime BirthDay { get; set; }
        public MaritalState MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public DateTime HireDate {get { return DateTime.Now.Date; }}
        public bool SalariedFlag {get { return true; }}
        public short HolidayHours { get {return 224;} }
        public short SickLeaveHours {get { return 40; }}
        public bool CurrentFlag { get{return true;} }
        public int ContactId { get; set; }
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public int PhotoId { get; set; }
    }
}
