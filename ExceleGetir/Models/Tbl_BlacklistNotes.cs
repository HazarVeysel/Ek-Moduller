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
    
    public partial class Tbl_BlacklistNotes
    {
        public int NoteId { get; set; }
        public string BlackListNote { get; set; }
        public Nullable<int> AddedUserId { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }
        public Nullable<int> FirmId { get; set; }
    }
}
