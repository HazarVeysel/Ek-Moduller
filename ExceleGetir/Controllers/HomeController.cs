using ClosedXML.Excel;
using ExceleGetir.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceleGetir.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public List<EMANIFESTO_SENETLER> SenetlerListele()
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {



                List<EMANIFESTO_SENETLER> senetler = db.Tbl_Loads.Where(x => x.PozisyonID == 80917).Select(x => new EMANIFESTO_SENETLER
                {

                    SENET_NUMARASI = x.txthblno,
                    GONDEREN_FIRMA_ADI = x.txtgonderici,
                    ALICI_FIRMA_ADI = x.txtalici,
                    BILDIRIM_TARAFI_ADI = "",           //
                    ACENTE_ADI = x.txtyurtdisiacente,
                    YUKLEME_LIMANI = x.txtyuklemelimani,
                    BOSALTMA_LIMANI = x.txttahliyelimani,
                    BEYAN_SAHIBI_VERGI_NO = 00,       //
                    TASIYICI_FIRMA_VERGI_NO = 00,       //
                    KONTEYNER_MI = (bool)x.Durum,       //
                    ILGILI_OZET_BEYAN_NUMARASI = "",    //
                    ACIKLAMA = x.txtaciklama1,
                    TRANSIT_MI = (bool)x.Durum         //



                }).ToList();


                return senetler;
            }

        }
        public List<EMANIFESTO_SATIRLAR> SatirlarListele()
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {



                List<EMANIFESTO_SATIRLAR> satirlar = db.Tbl_Konteyner.Where(x => x.PozisyonID == 80917).Select(x => new EMANIFESTO_SATIRLAR
                {

                    SENET_NUMARASI = "",    //
                    SATIR_NUMARASI = 00,    //                    
                    ESYA_CINSI = "",        //
                    GTIP = "",               //
                    KONTEYNER_NO = x.txtkonteynerno,
                    KONTEYNER_TIPI = x.cmbkonteynertipi,
                    KAP_CINSI = "",           //
                    KAP_ADEDI = 00,          //
                    OLCU_BIRIMI = "",        //
                    BRUT_AGIRLIK = x.txtbrutagirlik,
                    NETAGIRLIK = x.txtnetagirlik,
                    MUHUR_NUMARASI = x.txtmuhurno



                }).ToList();


                return satirlar;
            }

        }

        public ActionResult ExportExcel()
        {
            byte[] content = null;
            using (var workbook = new XLWorkbook())
            {
                //--------------------------GENEL--------------------------------
                var Worksheet_Genel = workbook.Worksheets.Add("EMANIFESTO_GENEL");
                
                
                Worksheet_Genel.Columns("1:2").Style.Font.SetFontSize(12);

                Worksheet_Genel.Cell(1, 1).Style.Fill.BackgroundColor = XLColor.Yellow;
                Worksheet_Genel.Cell(1, 1).Style.Font.SetBold(true);
                Worksheet_Genel.Cell(2, 1).Style.Fill.BackgroundColor = XLColor.Yellow;
                Worksheet_Genel.Cell(2, 1).Style.Font.SetBold(true);
                Worksheet_Genel.Cell(3, 1).Style.Fill.BackgroundColor = XLColor.Yellow;
                Worksheet_Genel.Cell(3, 1).Style.Font.SetBold(true);
                Worksheet_Genel.Cell(4, 1).Style.Fill.BackgroundColor = XLColor.Yellow;
                Worksheet_Genel.Cell(4, 1).Style.Font.SetBold(true);
                Worksheet_Genel.Cell(5, 1).Style.Fill.BackgroundColor = XLColor.Yellow;
                Worksheet_Genel.Cell(5, 1).Style.Font.SetBold(true);
                Worksheet_Genel.Cell(6, 1).Style.Fill.BackgroundColor = XLColor.Yellow;
                Worksheet_Genel.Cell(6, 1).Style.Font.SetBold(true);
                Worksheet_Genel.Row(1).Cells().Style.Border.SetOutsideBorderColor(XLColor.Black);
                Worksheet_Genel.Row(1).Cells().Style.Border.RightBorderColor=XLColor.Black;
                
                //Worksheet_Genel.Columns().autofit(; // this changes the column width to fit the content
                
                Worksheet_Genel.Cell(1, 1).Value = "Toplam Konteyner:";
                Worksheet_Genel.Cell(2, 1).Value = "Toplam Kap:";
                Worksheet_Genel.Cell(3, 1).Value = "Toplam Brüt Ağırlık:";
                Worksheet_Genel.Cell(4, 1).Value = "Yükleme/Boşaltma Limanı Toplam Konteyner:";
                Worksheet_Genel.Cell(5, 1).Value = "Yükleme/Boşaltma Limanı Toplam Kap:";
                Worksheet_Genel.Cell(6, 1).Value = "Yükleme/Boşaltma Limanı Toplam Brüt Ağırlık:";
                int rowgenel = 2;

                Worksheet_Genel.Cell(1, rowgenel).Value = 00;
                Worksheet_Genel.Cell(2, rowgenel).Value = 00;
                Worksheet_Genel.Cell(3, rowgenel).Value = 00;
                Worksheet_Genel.Cell(4, rowgenel).Value = 00;
                Worksheet_Genel.Cell(5, rowgenel).Value = 00;
                Worksheet_Genel.Cell(6, rowgenel).Value = 00;
                Worksheet_Genel.Rows().AdjustToContents();
                Worksheet_Genel.Columns().AdjustToContents();
                //rowgenel++;

                //--------------------------SENETLER------------------------------
                var Worksheet_Senetler = workbook.Worksheets.Add("EMANIFESTO_SENETLER");
                Worksheet_Senetler.Row(1).Style.Font.SetBold(true);
                Worksheet_Senetler.Row(1).Style.Font.SetUnderline();
                Worksheet_Senetler.Row(1).Style.Font.SetFontSize(12);
                Worksheet_Senetler.Row(1).Style.Font.SetFontColor(XLColor.White);
                Worksheet_Senetler.Row(1).Style.Fill.BackgroundColor = XLColor.LimeGreen;
                Worksheet_Senetler.Row(1).Cells().Style.Border.SetOutsideBorderColor(XLColor.Black);
                Worksheet_Senetler.Cell(1, 1).Value = "SENET NUMARASI";
                Worksheet_Senetler.Cell(1, 2).Value = "GÖNDEREN FIRMA ADI";
                Worksheet_Senetler.Cell(1, 3).Value = "ALICI FIRMA ADI";
                Worksheet_Senetler.Cell(1, 4).Value = "BILDIRIM TARAFI ADI";
                Worksheet_Senetler.Cell(1, 5).Value = "ACENTE ADI";
                Worksheet_Senetler.Cell(1, 6).Value = "YÜKLEME LIMANI";
                Worksheet_Senetler.Cell(1, 7).Value = "BOSALTMA LIMANI";
                Worksheet_Senetler.Cell(1, 8).Value = "BEYAN SAHIBI VERGI NO";
                Worksheet_Senetler.Cell(1, 9).Value = "TASIYICI FIRMA VERGI NO";
                Worksheet_Senetler.Cell(1, 10).Value = "KONTEYNER MI";
                Worksheet_Senetler.Cell(1, 11).Value = "ILGILI ÖZET BEYAN NUMARASI";
                Worksheet_Senetler.Cell(1, 12).Value = "AÇIKLAMA";
                Worksheet_Senetler.Cell(1, 13).Value = "TRANSİT Mİ";

                int rowcount = 2;

                foreach (var item in SenetlerListele())
                {
                    Worksheet_Senetler.Cell(rowcount, 1).Value = item.SENET_NUMARASI;
                    Worksheet_Senetler.Cell(rowcount, 2).Value = item.GONDEREN_FIRMA_ADI;
                    Worksheet_Senetler.Cell(rowcount, 3).Value = item.ALICI_FIRMA_ADI;
                    Worksheet_Senetler.Cell(rowcount, 4).Value = item.BILDIRIM_TARAFI_ADI;
                    Worksheet_Senetler.Cell(rowcount, 5).Value = item.ACENTE_ADI;
                    Worksheet_Senetler.Cell(rowcount, 6).Value = item.YUKLEME_LIMANI;
                    Worksheet_Senetler.Cell(rowcount, 7).Value = item.BOSALTMA_LIMANI;
                    Worksheet_Senetler.Cell(rowcount, 8).Value = item.BEYAN_SAHIBI_VERGI_NO;
                    Worksheet_Senetler.Cell(rowcount, 9).Value = item.TASIYICI_FIRMA_VERGI_NO;
                    Worksheet_Senetler.Cell(rowcount, 10).Value = item.KONTEYNER_MI;
                    Worksheet_Senetler.Cell(rowcount, 11).Value = item.ILGILI_OZET_BEYAN_NUMARASI;
                    Worksheet_Senetler.Cell(rowcount, 12).Value = item.ACIKLAMA;
                    Worksheet_Senetler.Cell(rowcount, 13).Value = item.TRANSIT_MI;
                    rowcount++;
                }
                Worksheet_Senetler.Rows().AdjustToContents();
                Worksheet_Senetler.Columns().AdjustToContents();

                //--------------------------SATIRLAR------------------------------
                var Worksheet_Satırlar = workbook.Worksheets.Add("EMANIFESTO_SATIRLAR");

                Worksheet_Satırlar.Row(1).Style.Font.SetBold(true);
                Worksheet_Satırlar.Row(1).Style.Font.SetUnderline();
                Worksheet_Satırlar.Row(1).Style.Font.SetFontSize(12);
                Worksheet_Satırlar.Row(1).Style.Font.SetFontColor(XLColor.White);
                Worksheet_Satırlar.Row(1).Style.Fill.BackgroundColor = XLColor.LimeGreen;
                Worksheet_Satırlar.Row(1).Cells().Style.Border.SetOutsideBorderColor(XLColor.Black);

                Worksheet_Satırlar.Cell(1, 1).Value = "SENET NUMARASI";
                Worksheet_Satırlar.Cell(1, 2).Value = "SATIR NUMARASI";
                Worksheet_Satırlar.Cell(1, 3).Value = "ESYA CINSI";
                Worksheet_Satırlar.Cell(1, 4).Value = "GTIP";
                Worksheet_Satırlar.Cell(1, 5).Value = "KONTEYNER NO";
                Worksheet_Satırlar.Cell(1, 6).Value = "KONTEYNER TIPI";
                Worksheet_Satırlar.Cell(1, 7).Value = "KAP CINSI";
                Worksheet_Satırlar.Cell(1, 8).Value = "KAP ADEDI";
                Worksheet_Satırlar.Cell(1, 9).Value = "ÖLÇÜ BIRIMI";
                Worksheet_Satırlar.Cell(1, 10).Value = "BRÜT AGIRLIK";
                Worksheet_Satırlar.Cell(1, 11).Value = "NET AGIRLIK";
                Worksheet_Satırlar.Cell(1, 12).Value = "MÜHÜR NUMARASI";

                int rowcount2 = 2;

                foreach (var item in SatirlarListele())
                {
                    Worksheet_Satırlar.Cell(rowcount2, 1).Value = item.SENET_NUMARASI;
                    Worksheet_Satırlar.Cell(rowcount2, 2).Value = item.SATIR_NUMARASI;
                    Worksheet_Satırlar.Cell(rowcount2, 3).Value = item.ESYA_CINSI;
                    Worksheet_Satırlar.Cell(rowcount2, 4).Value = item.GTIP;
                    Worksheet_Satırlar.Cell(rowcount2, 5).Value = item.KONTEYNER_NO;
                    Worksheet_Satırlar.Cell(rowcount2, 6).Value = item.KONTEYNER_TIPI;
                    Worksheet_Satırlar.Cell(rowcount2, 7).Value = item.KAP_CINSI;
                    Worksheet_Satırlar.Cell(rowcount2, 8).Value = item.KAP_ADEDI;
                    Worksheet_Satırlar.Cell(rowcount2, 9).Value = item.OLCU_BIRIMI;
                    Worksheet_Satırlar.Cell(rowcount2, 10).Value = item.BRUT_AGIRLIK;
                    Worksheet_Satırlar.Cell(rowcount2, 11).Value = item.NETAGIRLIK;
                    Worksheet_Satırlar.Cell(rowcount2, 12).Value = item.MUHUR_NUMARASI;
                    
                    rowcount2++;
                }
                Worksheet_Satırlar.Rows().AdjustToContents();
                Worksheet_Satırlar.Columns().AdjustToContents();

                using (var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    content = stream.ToArray();
                    
                }
            }
            string fileName = "Emanifesto " + DateTime.Now.ToString("dd-MM-yy_HH-mm") + ".xlsx";
            return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}