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
    
    public partial class Tbl_FaturaTalimatlari
    {
        public int id { get; set; }
        public string Aciklama { get; set; }
        public string KurTarihi { get; set; }
        public string EvrakTarihi { get; set; }
        public string Kur { get; set; }
        public Nullable<int> PozID { get; set; }
        public Nullable<int> LoadID { get; set; }
        public Nullable<int> ModulID { get; set; }
        public string EkleyenKullanici { get; set; }
        public string EklemeTarihi { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> Durum { get; set; }
        public Nullable<int> BranchID { get; set; }
        public Nullable<int> Onaylayan { get; set; }
        public string OnaylayanKullanici { get; set; }
        public string OnaylamaTarihi { get; set; }
    }
}
