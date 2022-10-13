using ExceleGetir.Entities;
using ExceleGetir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceleGetir.Controllers
{
    public class MaturityRequestController : Controller
    {
        MaturityRequest maturity_Request = new MaturityRequest();
        AdresKart AdrKart = new AdresKart();
        public ActionResult Index(int id)
        {
            //id = 1;
            MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();

            List<MaturityRequestView> yeniListe = new List<MaturityRequestView>();
            if (id == 3)
            {

                yeniListe = maturity_Request.ListMaturityRequestByCompany(0);                
                //adreskartandmaturityrequest.Adreskart= AdrKart.GetAdreskart()

            }
            else
            {
             
                yeniListe = maturity_Request.ListMaturityRequestByCompany(id);
                //adreskartandmaturityrequest.MaturityRequestList = maturity_Request.ListMaturityRequestByUser(id);
                
            }

            return View(yeniListe);
        }
        //public ActionResult RequestListByUser(int userid)
        //{
        //    MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
        //    if (userid==3)
        //    {

        //        adreskartandmaturityrequest.MaturityRequestList = maturity_Request.ListAllMaturityRequest();
        //        return PartialView("/Views/MaturityRequest/_RequestsPartial.cshtml",adreskartandmaturityrequest);
        //    }
        //    else
        //    {

        //        adreskartandmaturityrequest.MaturityRequestList = maturity_Request.ListMaturityRequestByUser(userid);
        //        return PartialView("/Views/MaturityRequest/_RequestsPartial.cshtml", adreskartandmaturityrequest);
        //    }

        //}
        public ActionResult MaturityRequestList()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddMaturityRequest()
        {

            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult DeclineMaturityRequest(Tbl_MaturityRequests maturityRequest)
        {
            MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
            
            maturityRequest.ActivityStatus = false;
            maturityRequest.ApprovalStatus = 0;
            maturityRequest.ApprovedDate = DateTime.Parse(DateTime.Now.ToString());
            maturity_Request.UpdateMaturityRequest(maturityRequest);
            var obj = maturityRequest.RequestId;
            adreskartandmaturityrequest.MaturityRequest = maturity_Request.GetMaturityRequest(obj);
            return Json(new { sonuc = "Declined", Id = obj }, JsonRequestBehavior.AllowGet);
        }
            [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddMaturityRequest(Tbl_MaturityRequests maturityRequest)
        {
            maturityRequest.RequirerUserId = 1;
            if (maturityRequest.RequestId > 0)
            {


                maturityRequest.UpdatedDate = DateTime.Parse(DateTime.Now.ToString());

                maturityRequest.ActivityStatus = true;
                maturity_Request.UpdateMaturityRequest(maturityRequest);
                var obj = maturityRequest.RequestId;

                return Json(new { sonuc = "Edited", Id = obj }, JsonRequestBehavior.AllowGet);

            }
            else

            {
                MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
                maturityRequest.RequestDate = DateTime.Parse(DateTime.Now.ToString());
                maturityRequest.ActivityStatus = true;
                maturity_Request.AddMaturityRequest(maturityRequest);
                var obj = maturityRequest.RequestId;
                adreskartandmaturityrequest.MaturityRequest = maturity_Request.GetMaturityRequest(obj);
                return Json(new { sonuc = "OK", Id = obj }, JsonRequestBehavior.AllowGet);

            }

        }
        public ActionResult GetFormPartial(int id)
        {
            //burdaki id=firmID
            MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
            //id = 6;
            if (id > 0)
            {
                //adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
                adreskartandmaturityrequest.Adreskart = AdrKart.GetAdreskart(id);
                //adreskartandmaturityrequest.MaturityRequest = (Tbl_MaturityRequests)maturity_Request.ListAllMaturityRequest().Where(x => x.FirmId == id);
                ViewBag.valuedays = GetDaysValue();
                return PartialView("/Views/MaturityRequest/_FormPartial.cshtml", adreskartandmaturityrequest);
            }
            else
            {
                //adreskartandmaturityrequest.Adreskart = new Tbl_AdresKartlari();
                adreskartandmaturityrequest.MaturityRequestList = new List<Tbl_MaturityRequests>();

                return PartialView("/Views/MaturityRequest/_FormPartial.cshtml", adreskartandmaturityrequest);
            }
        }
        public ActionResult GetFormByRequest(int id)
        {
            MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
            adreskartandmaturityrequest.MaturityRequest = maturity_Request.GetMaturityRequest(id);
            
            ViewBag.valuedays = GetDaysValue();
            int a = adreskartandmaturityrequest.MaturityRequest.FirmId ?? 0;
            adreskartandmaturityrequest.Adreskart = AdrKart.GetAdreskart(a);
            return PartialView("/Views/MaturityRequest/_FormPartial.cshtml", adreskartandmaturityrequest);
        }

        public ActionResult ApproveRequest(int id)
        {
            MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
            adreskartandmaturityrequest.MaturityRequest = maturity_Request.GetMaturityRequest(id);
            adreskartandmaturityrequest.MaturityRequest.ActivityStatus = false;
            adreskartandmaturityrequest.MaturityRequest.ApprovalStatus = 1;
            adreskartandmaturityrequest.MaturityRequest.ApprovedDate = DateTime.Parse(DateTime.Now.ToString());
            adreskartandmaturityrequest.MaturityRequest.ApproverUserId = 3;
            adreskartandmaturityrequest.Adreskart = AdrKart.GetAdreskart(adreskartandmaturityrequest.MaturityRequest.FirmId ?? 0);
            adreskartandmaturityrequest.Adreskart.cmbpaymentmaturity = adreskartandmaturityrequest.MaturityRequest.RequestedDays.ToString();

            maturity_Request.UpdateMaturityRequest(adreskartandmaturityrequest.MaturityRequest);

            return Json(new { sonuc = "Approved" }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult RevokeRequest(int id)
        {
            MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
            adreskartandmaturityrequest.MaturityRequest = maturity_Request.GetMaturityRequest(id);
            adreskartandmaturityrequest.MaturityRequest.ActivityStatus = false;
            maturity_Request.UpdateMaturityRequest(adreskartandmaturityrequest.MaturityRequest);

            return Json(new { sonuc = "Deleted" }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetDeclinePartial(int id)
        {
            MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
            adreskartandmaturityrequest.MaturityRequest = maturity_Request.GetMaturityRequest(id);

            return PartialView("/Views/MaturityRequest/_DeclinePartial.cshtml", adreskartandmaturityrequest);
        }

        public ActionResult GetMessagePartial(int id)
        {
            //burdaki id=firmID
            MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
            adreskartandmaturityrequest.MaturityRequest = maturity_Request.GetMaturityRequest(id);
            
                return PartialView("/Views/MaturityRequest/_MessagePartial.cshtml", adreskartandmaturityrequest);
            
        }
        public ActionResult GetDescriptionPartial(int id)
        {
            //burdaki id=firmID
            MaturityRequestAndAdresKartlari adreskartandmaturityrequest = new MaturityRequestAndAdresKartlari();
            adreskartandmaturityrequest.MaturityRequest = maturity_Request.GetMaturityRequest(id);

            return PartialView("/Views/MaturityRequest/_DescriptionPartial.cshtml", adreskartandmaturityrequest);

        }

        public class MaturityRequestAndAdresKartlari
        {
            public Tbl_AdresKartlari Adreskart { get; set; }
            public List<Tbl_AdresKartlari> AdresKartList { get; set; }
            public Tbl_MaturityRequests MaturityRequest { get; set; }
            public List<Tbl_MaturityRequests> MaturityRequestList { get; set; }
            
        }

        public static IEnumerable<SelectListItem> GetDaysValue()
        {
            IList<SelectListItem> valuedays = new List<SelectListItem>()
            {
                       new SelectListItem { Value = "5" ,  Text = "5 DAYS" },
                       new SelectListItem { Value = "7" ,  Text = "7 DAYS"  },
                       new SelectListItem { Value = "10" , Text = "10 DAYS" },
                       new SelectListItem { Value = "15" , Text = "15 DAYS" },
                       new SelectListItem { Value = "21" , Text = "21 DAYS" },
                       new SelectListItem { Value = "30" , Text = "30 DAYS" },
                       new SelectListItem { Value = "45" , Text = "45 DAYS" },
                       new SelectListItem { Value = "60" , Text = "60 DAYS" },
                       new SelectListItem { Value = "75" , Text = "75 DAYS" },
                       new SelectListItem { Value = "90" , Text = "90 DAYS" },
                       new SelectListItem { Value = "120", Text = "120 DAYS" }
            };
        return valuedays;
        }


        public class MaturityRequestView
        {
            public int RequestId { get; set; }
            public Nullable<int> FirmId { get; set; }
            public Nullable<int> RequirerUserId { get; set; }
            public Nullable<System.DateTime> RequestDate { get; set; }
            public string Description { get; set; }
            public Nullable<int> ApproverUserId { get; set; }
            public Nullable<System.DateTime> ApprovedDate { get; set; }
            public string DenialMessage { get; set; }
            public Nullable<int> ApprovalStatus { get; set; }
            public Nullable<int> RequestedDays { get; set; }
            public Nullable<System.DateTime> UpdatedDate { get; set; }
            public Nullable<bool> ActivityStatus { get; set; }
            public string CompanyName { get; set; }
        }
    }
}