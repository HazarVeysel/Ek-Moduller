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
    
    public partial class TBL_MAG_AKT_HATA
    {
        public int ROWID { get; set; }
        public Nullable<int> PKID { get; set; }
        public string POZNO { get; set; }
        public string PK_BELGENO { get; set; }
        public string Firmaadi { get; set; }
        public string PK_FIRMAKODU { get; set; }
        public Nullable<System.DateTime> PK_TARIH { get; set; }
        public string FM_BELGENO { get; set; }
        public Nullable<System.DateTime> FM_TARIH { get; set; }
        public string FM_FIRMAKODU { get; set; }
    }
}
