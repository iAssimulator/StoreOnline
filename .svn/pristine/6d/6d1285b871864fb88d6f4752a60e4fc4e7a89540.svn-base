using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class MemberUser
    {
        public MemberUser()
        {
            this.Employees = new List<Employee>();
            this.Customers = new List<Customer>();
        }

        public int MUS_ID { get; set; }
        public string MUS_Login { get; set; }
        public string MUS_LoweredLogin { get; set; }
        public string MUS_Password { get; set; }
        public string MUS_Email { get; set; }
        public string MUS_LoweredEmail { get; set; }
        public int MUS_RoleID { get; set; }
        public Guid? MUS_Token { get; set; }
        public DateTime? MUS_TokenCreatedAt { get; set; }
        public DateTime? MUS_TokenExpiresAt { get; set; }
        public string MUS_UserAgent { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual MemberRole MemberRole { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
