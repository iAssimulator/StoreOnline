using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOnline.Core.Models.DTOs
{
    public class UserRegistrationDto : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public Guid Token { get {return Guid.NewGuid();} }
        public DateTime TokenCreatedAt { get { return DateTime.Now; } }
        public DateTime TokenExpiresAt { get { return DateTime.Now.AddDays(1); } }
        public string UserAgent { get; set; }
    }
}
