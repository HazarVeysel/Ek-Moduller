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
    
    public partial class Tbl_MaturityRequests
    {
        public int RequestId { get; set; }
        public Nullable<int> FirmId { get; set; }
        public Nullable<int> RequirerUserId { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string Description { get; set; }
        public Nullable<int> ApproverUserId { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public string DenialMessage { get; set; }
        public Nullable<int> ApprovalStatus { get; set; }
        public Nullable<int> RequestedDays { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> ActivityStatus { get; set; }
    }
}