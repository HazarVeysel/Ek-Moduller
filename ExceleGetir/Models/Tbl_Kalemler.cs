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
    
    public partial class Tbl_Kalemler
    {
        public int id { get; set; }
        public string KalemAdiDE { get; set; }
        public string KalemAdiEN { get; set; }
        public string KalemAdi { get; set; }
        public string Sube { get; set; }
        public string AB { get; set; }
        public string Kdvdurum { get; set; }
        public string KdvOrani { get; set; }
        public string RaporGrubu { get; set; }
        public Nullable<int> Deniz { get; set; }
        public Nullable<int> Hava { get; set; }
        public Nullable<int> Kara { get; set; }
        public Nullable<int> Isotank { get; set; }
        public Nullable<int> Ticari { get; set; }
        public Nullable<int> ith_ihr { get; set; }
        public Nullable<int> Yurtici_disi { get; set; }
        public Nullable<int> Pozisyon { get; set; }
        public Nullable<bool> Muhasebe { get; set; }
        public Nullable<bool> sikkullanilan { get; set; }
        public Nullable<bool> Tekrarkesilebilir { get; set; }
        public Nullable<bool> KdvDegistirilebilir { get; set; }
        public Nullable<bool> KdvSabit { get; set; }
        public string gelirgiderhesabi { get; set; }
        public string kdvhesapno { get; set; }
        public string kdvsizhesapno { get; set; }
        public string yurtdisihesapno { get; set; }
        public string masrafyeri { get; set; }
        public string BaglantiYeri1 { get; set; }
        public string KullananFirmalar { get; set; }
        public string GoruntuDili { get; set; }
        public Nullable<int> Tevkifat { get; set; }
    }
}
