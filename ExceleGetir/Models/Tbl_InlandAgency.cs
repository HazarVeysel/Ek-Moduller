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
    
    public partial class Tbl_InlandAgency
    {
        public int id { get; set; }
        public string AgencyType { get; set; }
        public string FirmaKodu { get; set; }
        public string SubeKodu { get; set; }
        public string SehirAdi { get; set; }
        public string AcenteAdi { get; set; }
        public string AcenteKodu { get; set; }
        public string GuncelleyenKullanici { get; set; }
        public string GuncellemeTarihi { get; set; }
        public string EkleyenKullanici { get; set; }
        public string EklemeTarihi { get; set; }
        public Nullable<int> PortType { get; set; }
        public Nullable<int> OrderNr { get; set; }
    }
}
