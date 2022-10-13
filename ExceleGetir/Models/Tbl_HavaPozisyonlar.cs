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
    
    public partial class Tbl_HavaPozisyonlar
    {
        public int id { get; set; }
        public string FirmaNo { get; set; }
        public string RezervasyonNo { get; set; }
        public Nullable<int> Rezerve { get; set; }
        public Nullable<int> ithihr { get; set; }
        public string pozno { get; set; }
        public string pozisyonno { get; set; }
        public string txtistipi { get; set; }
        public string txtsube { get; set; }
        public string txtopgrup { get; set; }
        public string txtacilistarihi { get; set; }
        public string txtacilistarihilong { get; set; }
        public string txtkapanistarihi { get; set; }
        public string txtyurtdisiacente { get; set; }
        public string txtmblno { get; set; }
        public string txtmbltarihi { get; set; }
        public string txthat { get; set; }
        public string txtkonteynerdolumtar { get; set; }
        public string txtbeklenenvaristar { get; set; }
        public string txtkalkistarihi { get; set; }
        public string txtvaristarihi { get; set; }
        public string txtyurtdisigemiacentesi { get; set; }
        public string txtyuklemelimani { get; set; }
        public string txtyuklemelimanitar { get; set; }
        public string txtyuklemegemisi { get; set; }
        public string txtyuklemegemisiseferno { get; set; }
        public string txtaktarmalimani { get; set; }
        public string txtaktarmalimanitar { get; set; }
        public string txtaktarmagemisi { get; set; }
        public string txtaktarmagemisiseferno { get; set; }
        public string txtaktarmahatadi { get; set; }
        public string txtaktarmahatkodu { get; set; }
        public string txtaktarma2limani { get; set; }
        public string txtaktarma2limanitar { get; set; }
        public string txtaktarma2gemisiseferno { get; set; }
        public string txtaktarma2hatadi { get; set; }
        public string txtaktarma2hatkodu { get; set; }
        public string txttahliyelimani { get; set; }
        public string txttahliyelimanitarihi { get; set; }
        public string txttahliyegemisi { get; set; }
        public string txttahliyegemisiseferno { get; set; }
        public string txtmanifestono { get; set; }
        public string txtmanifestotarihi { get; set; }
        public string txtgumrukluantrepo { get; set; }
        public string txtgumrukluantrepokod { get; set; }
        public string txtgumrukyeri { get; set; }
        public string txtgumrukyerikod { get; set; }
        public string txtozetbeyanreferansno { get; set; }
        public Nullable<int> ckgrupaj { get; set; }
        public Nullable<int> ckambarharici { get; set; }
        public Nullable<int> LinerYukleme { get; set; }
        public Nullable<int> CrossYukleme { get; set; }
        public string txtnavluntarifesi { get; set; }
        public Nullable<int> txtnavluntardurum { get; set; }
        public string txtyurtdisiacentetar { get; set; }
        public Nullable<int> txtyurtdisiacentetardurum { get; set; }
        public string txtlimantarifesi { get; set; }
        public Nullable<int> txtlimantarifesidurum { get; set; }
        public string txticnakliyetarifesi { get; set; }
        public Nullable<int> txticnakliyetarifesidurum { get; set; }
        public string txtdemurajtarifesi { get; set; }
        public Nullable<int> txtdemurajtarifesidurum { get; set; }
        public Nullable<int> chkozetbeyantarifesidurum { get; set; }
        public string txtozetbeyantarifesi { get; set; }
        public string cmbincoterms { get; set; }
        public string toplambrutagirlik { get; set; }
        public string toplamnetagirlik { get; set; }
        public string toplamhacim { get; set; }
        public Nullable<int> toplamkolisayisi { get; set; }
        public string toplamkonteyner { get; set; }
        public string toplamnavlun { get; set; }
        public string txtyurtdisiacentekod { get; set; }
        public string txthatkod { get; set; }
        public string txtyuklemelimanikod { get; set; }
        public string txtaktarmalimanikod { get; set; }
        public string txtaktarma2limanikod { get; set; }
        public string txttahliyelimanikod { get; set; }
        public string txtyurtdisigemiacentesikod { get; set; }
        public string txtyuklemegemisikod { get; set; }
        public string txtaktarmagemisikod { get; set; }
        public string txttahliyegemisikod { get; set; }
        public string txthavayoluantrepo { get; set; }
        public string txthavayoluantrepokod { get; set; }
        public string ekleyenkullanici { get; set; }
        public string eklemetarihi { get; set; }
        public string guncelleyenkullanici { get; set; }
        public string guncellemetarihi { get; set; }
        public Nullable<bool> Durum { get; set; }
        public string KullananKullanici { get; set; }
        public string KullanimBaslangic { get; set; }
        public string KullanimSon { get; set; }
        public Nullable<int> KullanimDurum { get; set; }
        public Nullable<int> KarZararDurum { get; set; }
        public string ZararAciklama { get; set; }
        public string BrutKarZararTL { get; set; }
        public string BrutKarZarar { get; set; }
        public string BrutKarZararEUR { get; set; }
        public string ToplamKarZararTL { get; set; }
        public string ToplamKarZarar { get; set; }
        public string ToplamKarZararEUR { get; set; }
        public string ToplamGelirlerTL { get; set; }
        public string ToplamGelirler { get; set; }
        public string ToplamGelirlerEUR { get; set; }
        public string FinansalGider { get; set; }
        public string FinansalGiderTL { get; set; }
        public string FinansalGiderEUR { get; set; }
        public string KarCiroOrani { get; set; }
        public string TeuAdeti { get; set; }
        public string TeuBasiKarZarar { get; set; }
        public string Kont20adet { get; set; }
        public string Kont40adet { get; set; }
        public string LclWmCbm { get; set; }
        public string LclBasiKarZarar { get; set; }
        public string Aciklama { get; set; }
        public Nullable<int> ProjeID { get; set; }
        public Nullable<int> ProjeSira { get; set; }
        public string Personel { get; set; }
        public Nullable<int> PersonelID { get; set; }
        public Nullable<int> DenetimDurum { get; set; }
        public string DenetimAciklama { get; set; }
        public Nullable<int> OzetBeyanDurum { get; set; }
        public string OzetBeyanEntNo { get; set; }
        public string OzetBeyanNo { get; set; }
        public string txtekbilgi { get; set; }
    }
}
