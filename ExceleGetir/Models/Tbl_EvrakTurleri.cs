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
    
    public partial class Tbl_EvrakTurleri
    {
        public int id { get; set; }
        public string EvrakTuru { get; set; }
        public Nullable<int> Modul { get; set; }
        public Nullable<int> IthIhr { get; set; }
        public Nullable<int> PozYuk { get; set; }
        public Nullable<int> Zorunlu { get; set; }
        public Nullable<int> FirmaAdiZorunlu { get; set; }
        public Nullable<int> MusteriZorunlu { get; set; }
        public string IncoTerms { get; set; }
        public Nullable<int> LinerYukleme { get; set; }
        public Nullable<int> CrossYukleme { get; set; }
        public string Istipi { get; set; }
    }
}
