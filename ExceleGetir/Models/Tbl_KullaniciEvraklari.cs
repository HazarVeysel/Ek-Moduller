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
    
    public partial class Tbl_KullaniciEvraklari
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string EvrakAdi { get; set; }
        public string EvrakAciklama { get; set; }
        public string DosyaAdi { get; set; }
        public string GuncelleyenKullanici { get; set; }
        public Nullable<System.DateTime> GuncellemeTarihi { get; set; }
        public string EkleyenKullanici { get; set; }
        public Nullable<System.DateTime> EklemeTarihi { get; set; }
    }
}
