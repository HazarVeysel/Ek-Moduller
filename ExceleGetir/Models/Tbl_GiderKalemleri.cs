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
    
    public partial class Tbl_GiderKalemleri
    {
        public int id { get; set; }
        public string FirmaNo { get; set; }
        public string KalemAdiEN { get; set; }
        public string KalemAdi { get; set; }
        public string Sube { get; set; }
        public Nullable<int> AB { get; set; }
        public Nullable<bool> Kdvdurum { get; set; }
        public string KdvOrani { get; set; }
        public string RaporGrubu { get; set; }
        public bool sikkullanilan { get; set; }
        public string kdvhesapno { get; set; }
        public string orjinaltutar { get; set; }
        public string DovizKodu { get; set; }
        public string Firmaadi { get; set; }
        public Nullable<int> FirmaKodu { get; set; }
        public string BelgeTarihi { get; set; }
        public string Belgeno { get; set; }
        public string Aratltutari { get; set; }
        public string Kdvtltutari { get; set; }
        public string Orjdoviz { get; set; }
        public string kdvdahiltutar { get; set; }
        public string islemtarihi { get; set; }
        public string faturadoviztutari { get; set; }
        public string faturadovizkodu { get; set; }
        public string ekleyenkullanici { get; set; }
        public string eklemetarihi { get; set; }
        public string guncelleyenkullanici { get; set; }
        public string guncellemetarihi { get; set; }
        public Nullable<int> KalemID { get; set; }
    }
}