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
    
    public partial class Tbl_User_Competences
    {
        public int ID { get; set; }
        public int Performance_ID { get; set; }
        public string Basic_Competences { get; set; }
        public Nullable<bool> Strengths { get; set; }
        public Nullable<bool> Meets_Expectations { get; set; }
        public Nullable<bool> Development_Areas { get; set; }
        public Nullable<bool> Exempt { get; set; }
        public string Explanation { get; set; }
    }
}
