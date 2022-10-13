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
    public class BirDigerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
   
        public class satirvesenet
        {
            public List<Tbl_Konteyner> KonteynerList { get; set; }
            public List<Tbl_Loads> LoadsList { get; set; }

        }

        public ActionResult Diger()
        {

            satirvesenet satirvesenet = new satirvesenet();
            using (bati_serverEntities db = new bati_serverEntities())
            {
                satirvesenet.LoadsList = db.Tbl_Loads.Where(x => x.PozisyonID == 80917).ToList();
                satirvesenet.KonteynerList = db.Tbl_Konteyner.Where(x => x.PozisyonID == 80917).ToList();


             

            }
                
            return View(satirvesenet);
        }
      
    }
}