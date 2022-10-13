using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExceleGetir.Models
{
    public class EMANIFESTO_SENETLER
    {
        public string SENET_NUMARASI { get; set; }
        public string GONDEREN_FIRMA_ADI { get; set; }
        public string ALICI_FIRMA_ADI { get; set; }
        public string BILDIRIM_TARAFI_ADI { get; set; }
        public string ACENTE_ADI { get; set; }
        public string YUKLEME_LIMANI { get; set; }
        public string BOSALTMA_LIMANI { get; set; }
        public int? BEYAN_SAHIBI_VERGI_NO { get; set; }
        public int? TASIYICI_FIRMA_VERGI_NO{ get; set; }
        public bool? KONTEYNER_MI{ get; set; }
        public string ILGILI_OZET_BEYAN_NUMARASI { get; set; }
        public string ACIKLAMA { get; set; }
        public bool? TRANSIT_MI{ get; set; }



                    

    }
}