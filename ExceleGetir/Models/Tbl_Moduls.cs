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
    
    public partial class Tbl_Moduls
    {
        public int id { get; set; }
        public string ModulAdi { get; set; }
        public string ModulAdiEN { get; set; }
        public string ModulAdiDE { get; set; }
        public string MCode { get; set; }
        public Nullable<int> FirmaSecimi { get; set; }
        public Nullable<int> TurSecimi { get; set; }
        public byte[] TileImage { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> AnaEkran { get; set; }
    }
}
