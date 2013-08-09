using System;
using System.Collections.Generic;

namespace StoreManager.Core.Models
{
    public partial class OSCounty
    {
        public OSCounty()
        {
            this.Gazetteers = new List<Gazetteer>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Gazetteer> Gazetteers { get; set; }
    }
}
