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
    
    public partial class TBL_INTRA_TRACKING
    {
        public int ID { get; set; }
        public string STATUS { get; set; }
        public string STATUS_DATE { get; set; }
        public string LOCATION { get; set; }
        public string LOCATION_COUNTRY { get; set; }
        public string BOOKING_NUMBER { get; set; }
        public string BL_NUMBER { get; set; }
        public string CONVEYANCE_NAME { get; set; }
        public string VOYAGE_NO { get; set; }
        public string PORTOFLOADING_CODE { get; set; }
        public string PORTOFLOADING_COUNTRY { get; set; }
        public Nullable<System.DateTime> PORTOFLOADING_EST_DATE { get; set; }
        public Nullable<System.DateTime> PORTOFLOADING_ACT_DATE { get; set; }
        public string PORTOFDISCHARGE_CODE { get; set; }
        public string PORTOFDISCHARGE_COUNTRY { get; set; }
        public Nullable<System.DateTime> PORTOFDISCHARGE_EST_DATE { get; set; }
        public Nullable<System.DateTime> PORTOFDISCHARGE_ACT_DATE { get; set; }
        public string PLACEOFRECEIPT_CODE { get; set; }
        public string PLACEOFRECEIPT_COUNTRY { get; set; }
        public Nullable<System.DateTime> PLACEOFRECEIPT_EST_DATE { get; set; }
        public Nullable<System.DateTime> PLACEOFRECEIPT_ACT_DATE { get; set; }
        public string PLACEOFDELIVERY_CODE { get; set; }
        public string PLACEOFDELIVERY_COUNTRY { get; set; }
        public Nullable<System.DateTime> PLACEOFDELIVERY_EST_DATE { get; set; }
        public Nullable<System.DateTime> PLACEOFDELIVERY_ACT_DATE { get; set; }
        public string FILE_NAME { get; set; }
    }
}
