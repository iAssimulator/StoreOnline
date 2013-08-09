using System;
using System.Collections.Generic;

namespace StoreManager.Core.Models
{
    public partial class Gazetteer
    {
        public int SeqNo { get; set; }
        public string PlaceName { get; set; }
        public string CountyCode { get; set; }
        public string FeatureCode { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<double> Latitude { get; set; }
        public System.Data.Entity.Spatial.DbGeography GeoLocation { get; set; }
        public virtual Feature Feature { get; set; }
        public virtual OSCounty OSCounty { get; set; }
    }
}
