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
    
    public partial class Tbl_HavaFirmalari
    {
        public int id { get; set; }
        public string FirmaAdi { get; set; }
        public string FirmaKodu { get; set; }
        public string KisaKodu { get; set; }
        public string Ulkesi { get; set; }
        public string UlkeAdi { get; set; }
        public string Sehir { get; set; }
        public string SehirKodu { get; set; }
        public Nullable<int> Mod7Durum { get; set; }
        public string IAC { get; set; }
        public string CalismaDoviz { get; set; }
        public string ekleyenkullanici { get; set; }
        public string guncelleyenkullanici { get; set; }
        public string eklemetarihi { get; set; }
        public string guncellemetarihi { get; set; }
    }
}
