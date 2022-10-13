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
    
    public partial class Tbl_Meetings
    {
        public int id { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string MeetingDate { get; set; }
        public string CompanyName { get; set; }
        public string Rivals { get; set; }
        public string MeetingType { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Staff { get; set; }
        public string CustomerParticipants { get; set; }
        public Nullable<System.DateTime> Mdate { get; set; }
        public string MDatelong { get; set; }
        public Nullable<int> Assigned { get; set; }
        public Nullable<int> Departman { get; set; }
        public Nullable<int> Color { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> AllDay { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public Nullable<int> Status1 { get; set; }
        public Nullable<int> Label { get; set; }
        public string ResourceID { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public string CustomField1 { get; set; }
        public Nullable<int> ScheduleType { get; set; }
    }
}