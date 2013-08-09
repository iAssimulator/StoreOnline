using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class MemberRole
    {
        public MemberRole()
        {
            this.MemberUsers = new List<MemberUser>();
        }

        public int MRO_ID { get; set; }
        public string MRO_RoleName { get; set; }
        public string MRO_LoweredRoleName { get; set; }
        public string MRO_Description { get; set; }
        public virtual ICollection<MemberUser> MemberUsers { get; set; }
    }
}
