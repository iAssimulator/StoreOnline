using System;
using System.Collections.Generic;

namespace StoreOnline.Core.Models
{
    public partial class Photo
    {
        public Photo()
        {
            this.Employees = new List<Employee>();
        }

        public int PhotoID { get; set; }
        public byte[] Avatar { get; set; }
        public byte[] MainPhoto { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
