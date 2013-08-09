using System;
using System.Collections.Generic;

namespace StoreManager.Core.Models
{
    public partial class PostCodeData
    {
        public string OutwardCode { get; set; }
        public string InwardCode { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<double> Latitude { get; set; }
        public System.Data.Entity.Spatial.DbGeography GeoLocation { get; set; }
    }
}
