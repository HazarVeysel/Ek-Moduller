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
    
    public partial class Tbl_BankDetails
    {
        public int id { get; set; }
        public Nullable<int> FirmaID { get; set; }
        public string txtbankaadi { get; set; }
        public string txtbankaadresi { get; set; }
        public string txtsube { get; set; }
        public string txtswiftkodu { get; set; }
        public string txthesapno { get; set; }
        public string txtibanno { get; set; }
        public string txtmuhabirbankaadi { get; set; }
        public string txtmuhabirbankaadresi { get; set; }
        public string txtmuhabirsube { get; set; }
        public string txtmuhabirswiftkodu { get; set; }
        public string txtmuhabirhesapno { get; set; }
        public string txtmuhabiribanno { get; set; }
        public string BankaDovizi { get; set; }
        public string MuhabirDovizi { get; set; }
        public string GuncelleyenKullanici { get; set; }
        public string GuncellemeTarihi { get; set; }
        public string EkleyenKullanici { get; set; }
        public string EklemeTarihi { get; set; }
    }
}