//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExceleGetir.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_MT_Vessels_Locations
    {
        public int ID { get; set; }
        public Nullable<int> IMO { get; set; }
        public Nullable<int> MMSI { get; set; }
        public string LAT { get; set; }
        public string LON { get; set; }
        public Nullable<int> SPEED { get; set; }
        public Nullable<int> HEADING { get; set; }
        public Nullable<int> COURSE { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<System.DateTime> TIMESTAMP { get; set; }
        public string DSRC { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}
