using System;
using System.Collections.Generic;

namespace StoreManager.Core.Models
{
    public partial class Feature
    {
        public Feature()
        {
            this.Gazetteers = new List<Gazetteer>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Gazetteer> Gazetteers { get; set; }
    }
}
