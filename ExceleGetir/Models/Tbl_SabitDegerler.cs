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
    
    public partial class Tbl_SabitDegerler
    {
        public int id { get; set; }
        public string GiderFaturasiGirisiEngelleme { get; set; }
        public string Yillikizin { get; set; }
        public byte[] ModulSecimiArkaplan { get; set; }
        public Nullable<int> ArkaplanOncelik { get; set; }
        public Nullable<int> Versiyon { get; set; }
        public string IntraPostURL { get; set; }
        public string IntraUsername { get; set; }
        public string IntraPassword { get; set; }
        public string Logo_Database_IP { get; set; }
        public string Logo_UserName { get; set; }
        public string Logo_Password { get; set; }
        public Nullable<int> UploadLimit { get; set; }
        public Nullable<double> FinansmanGiderOrani { get; set; }
        public Nullable<double> FinansmanGiderOraniDoviz { get; set; }
        public byte[] EskiArkaplan { get; set; }
    }
}
