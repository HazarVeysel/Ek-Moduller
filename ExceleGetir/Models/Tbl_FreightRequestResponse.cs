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
    
    public partial class Tbl_FreightRequestResponse
    {
        public int id { get; set; }
        public Nullable<int> FreightID { get; set; }
        public string InternalShippingStatus { get; set; }
        public string DeadlineStatus { get; set; }
        public string AgencyPricing { get; set; }
        public string ShipOwner { get; set; }
        public string FreightCoverage { get; set; }
        public Nullable<System.DateTime> ValidityDate { get; set; }
        public string FreeTime { get; set; }
        public string VGMIncluded { get; set; }
        public string BLFEEIncluded { get; set; }
        public Nullable<int> TransitTime { get; set; }
        public string ServiceInformation { get; set; }
        public string BookingNo { get; set; }
        public string Notes { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> UpdatedUserId { get; set; }
        public string UpdatingUser { get; set; }
        public Nullable<System.DateTime> DateofUpdate { get; set; }
        public Nullable<int> AddedUserId { get; set; }
        public string AddedUser { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<int> ApprovedUserId { get; set; }
        public string ApprovingUser { get; set; }
        public Nullable<System.DateTime> ApprovedUserDate { get; set; }
    }
}