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
    
    public partial class Tbl_BABS_Approve
    {
        public int ID { get; set; }
        public string Gonderen_Adi_Soyadi { get; set; }
        public Nullable<System.DateTime> Gonderme_Tarihi { get; set; }
        public string Gonderilen_Mail { get; set; }
        public Nullable<int> Gonderilen_Sirket_ID { get; set; }
        public string Gonderilen_Sirket_Adi { get; set; }
        public Nullable<int> Gonderen_Kullanici_ID { get; set; }
        public string Muhasebe_Kodu { get; set; }
        public Nullable<decimal> USD { get; set; }
        public Nullable<int> USD_Durum { get; set; }
        public string USD_Aciklama { get; set; }
        public Nullable<decimal> EUR { get; set; }
        public Nullable<int> EUR_Durum { get; set; }
        public string EUR_Aciklama { get; set; }
        public Nullable<decimal> TL { get; set; }
        public Nullable<int> TL_Durum { get; set; }
        public string TL_Aciklama { get; set; }
        public Nullable<decimal> GBP { get; set; }
        public Nullable<int> GBP_Durum { get; set; }
        public string GBP_Aciklama { get; set; }
        public Nullable<System.DateTime> Onaylama_Tarihi { get; set; }
        public Nullable<int> Mail_Gonderme_Durum { get; set; }
        public Nullable<int> Mail_Onaylanma_Durum { get; set; }
        public string Onay_Iptal_Aciklama { get; set; }
        public string Onaylayan_Ad_Soyad { get; set; }
        public string Onaylayan_Unvan { get; set; }
        public string Onaylayan_IP_Adresi { get; set; }
    }
}
