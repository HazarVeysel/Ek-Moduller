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
    
    public partial class Tbl_Evraklar
    {
        public int id { get; set; }
        public string Evrak_Adi { get; set; }
        public string EvrakNo { get; set; }
        public Nullable<int> Tur { get; set; }
        public Nullable<int> PozYuk { get; set; }
        public Nullable<int> IthIhr { get; set; }
        public string FirmaOzelKod { get; set; }
        public string Evrak_Yolu { get; set; }
        public string BeklenenDegerler { get; set; }
        public Nullable<int> LinerBL { get; set; }
        public Nullable<int> CrossBL { get; set; }
    }
}
