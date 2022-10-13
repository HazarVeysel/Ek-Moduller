using ClosedXML.Excel;
using ExceleGetir.Entities;
using ExceleGetir.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceleGetir.Controllers
{
    public class BlackListController : Controller
    {
        AdresKart AdrKart = new AdresKart();

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult AdresKartlariList()
        {


            //using (bati_serverEntities db = new bati_serverEntities())
            //{
            //    var AdresKart = db.Tbl_AdresKartlari.Where(x => x.BLStatus == 1).ToList();

            //    return View(AdresKart);


            //}

            return View();
        }
        public ActionResult BlacklistDatas()
        {


            using (bati_serverEntities db = new bati_serverEntities())
            {
                var AdresKart = db.Tbl_AdresKartlari.Where(x => x.BLStatus == 1).ToList();


                return Json(new { data = AdresKart }, JsonRequestBehavior.AllowGet);

            }


        }
        [HttpGet]
        public ActionResult EditAddresKart(int id)
        {
            var categoryValue = AdrKart.GetAdreskart(id);
            List<SelectListItem> valuecategory = (from x in AdrKart.ListAllAdreskart()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.musteradi,
                                                      Value = x.id.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;

            return View(categoryValue);
        }
        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult EditCategory(Tbl_AdresKartlari adreskarti)
        //{
        //    var adreskartvalue = AdrKart.GetAdreskart(adreskarti.id);
        //    List<SelectListItem> valuecategory = (from x in AdrKart.ListAllAdreskart()
        //                                          select new SelectListItem
        //                                          {
        //                                              Text = x.musteradi,
        //                                              Value = x.id.ToString()
        //                                          }).ToList();
        //    ViewBag.vlc = valuecategory;


        //    adreskartvalue.musteradi = adreskarti.musteradi;




        //    AdrKart.UpdateAdreskart(adreskartvalue);

        //    return RedirectToAction("AdminCategories");
        //}
        [HttpGet]
        public ActionResult AddToBlackList()
        {
            List<SelectListItem> valueadrkart = (from x in AdrKart.ListAllAdreskart()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.musteradi,
                                                     Value = x.id.ToString()
                                                 }).ToList();
            ViewBag.vlc = valueadrkart;
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddToBlackList(Tbl_AdresKartlari adreskart)
        {
            if (adreskart.id > 0)
            {
                adreskart.BLAddedDate = DateTime.Parse(DateTime.Now.ToString());
                adreskart.BLUpdatedDate = DateTime.Parse(DateTime.Now.ToString());
                
                AdrKart.UpdateAdreskart(adreskart);
                var obj = adreskart.id;
                return Json(new { sonuc = "Updated", Id = obj }, JsonRequestBehavior.AllowGet);
            }
            else
            {

                adreskart.BLAddedDate = DateTime.Parse(DateTime.Now.ToString());
                adreskart.BLUpdatedDate = DateTime.Parse(DateTime.Now.ToString());
                
                AdrKart.AddToBlackList(adreskart);
                var obj = adreskart.id;
                return Json(new { sonuc = "OK", Id = obj }, JsonRequestBehavior.AllowGet);
            }
            
        }
        [HttpGet]
        public ActionResult AddNewNote()
        {

            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddNewNote(Tbl_BlacklistNotes blnote)
        {
            blnote.AddedDate = DateTime.Parse(DateTime.Now.ToString());
            //adreskart.BLAddedUpdatedId = BLAddedUpdateId;
            //adreskart.BLAddedUpdateName = BLAddedUpdateUserName;
            blnote.AddedUserId = 1;
            //blnote.FirmId = 12345;
            AdrKart.AddToBlackListNote(blnote);
            //return RedirectToAction("AdresKartlariList");
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
        public ActionResult partialcagir(int id = 0)
        {
            ViewModel adreskartandblacklistnotes = new ViewModel();
            if (id > 0)
            {
                adreskartandblacklistnotes = new ViewModel();
                adreskartandblacklistnotes.Adreskart = AdrKart.GetAdreskart(id);
                adreskartandblacklistnotes.BlacklistNotes = AdrKart.ListAllBlNotes().Where(x => x.FirmId == id);

                return PartialView("/Views/BlackList/_addtoblacklist.cshtml", adreskartandblacklistnotes);
            }
            else
            {
                adreskartandblacklistnotes.Adreskart = new Tbl_AdresKartlari();
                adreskartandblacklistnotes.BlacklistNotes = new List<Tbl_BlacklistNotes>();

                return PartialView("/Views/BlackList/_addtoblacklist.cshtml", adreskartandblacklistnotes);
            }
        }
        public ActionResult GetNotesPartial(int id)
        {
            ViewModel adreskartBlacklistNotes = new ViewModel();
            adreskartBlacklistNotes.BlacklistNotes = AdrKart.ListAllBlNotes().Where(x => x.FirmId == id);
            return PartialView("/Views/BlackList/_blnotes.cshtml", adreskartBlacklistNotes);
        }
        
        public class ViewModel
        {
            public Tbl_AdresKartlari Adreskart { get; set; }
            public Tbl_BlacklistNotes BlacklistNoteFirmId { get; set; }
            public IEnumerable<Tbl_BlacklistNotes> BlacklistNotes { get; set; }
        }
    }
}