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
    
    public partial class Tbl_Masraflar
    {
        public int id { get; set; }
        public Nullable<int> UserID { get; set; }
        public string MasrafNo { get; set; }
        public string Sira { get; set; }
        public string Aciklama { get; set; }
        public string MasrafTuru { get; set; }
        public string FisTarihi { get; set; }
        public string FisNo { get; set; }
        public Nullable<double> FisTutari { get; set; }
        public string Doviz { get; set; }
        public Nullable<double> FisTutariUSD { get; set; }
        public Nullable<double> FisTutariEUR { get; set; }
        public Nullable<long> MasrafGrubu { get; set; }
        public string KayitTarihi { get; set; }
        public string EvrakTarihi { get; set; }
    }
}