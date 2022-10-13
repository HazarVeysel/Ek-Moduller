using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ExceleGetir.Models;
using static ExceleGetir.Controllers.MaturityRequestController;

namespace ExceleGetir.Entities
{

    public interface IMaturityRequest
    {
        void AddMaturityRequest(Tbl_MaturityRequests maturityRequest);
        void UpdateMaturityRequest(Tbl_MaturityRequests maturityRequest);
        void DeleteMaturityRequest(int requestid);
        List<Tbl_MaturityRequests> ListAllMaturityRequest();
        List<Tbl_MaturityRequests> ListMaturityRequestByUser(int userid);
        List<MaturityRequestView> ListMaturityRequestByCompany(int userID);
    }

    public class MaturityRequest : IMaturityRequest
    {
        public void AddMaturityRequest(Tbl_MaturityRequests maturityRequest)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {
                var AddedMaturityRequest = db.Entry(maturityRequest);
                AddedMaturityRequest.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void UpdateMaturityRequest(Tbl_MaturityRequests maturityRequest)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {
                //context üretmedik çünkü contextimiz burda db
                var updatedMaturityRequest = db.Entry(maturityRequest);

                updatedMaturityRequest.State = EntityState.Modified;
                db.SaveChanges();

            }
        }

        public void DeleteMaturityRequest(int requestid)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {

                var deletedMaturityRequest = db.Tbl_MaturityRequests.SingleOrDefault(x => x.RequestId == requestid);

                db.Entry(deletedMaturityRequest).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public Tbl_MaturityRequests GetMaturityRequest(int requestid)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {
                Tbl_MaturityRequests selectedMaturityRequest = db.Tbl_MaturityRequests.SingleOrDefault(x => x.RequestId == requestid);
                return selectedMaturityRequest;
            }
        }

        public Tbl_MaturityRequests GetMaturityRequestByUser(int userid)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {
                Tbl_MaturityRequests selectedMaturityRequest = db.Tbl_MaturityRequests.SingleOrDefault(x => x.RequirerUserId == userid);
                return selectedMaturityRequest;
            }
        }

        public List<Tbl_MaturityRequests> ListAllMaturityRequest()
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {

                return db.Tbl_MaturityRequests.ToList();

            }
        }
        
        public List<Tbl_MaturityRequests> ListMaturityRequestByUser(int userid)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {

                return db.Tbl_MaturityRequests.Where(x=>x.RequirerUserId==userid).ToList();

            }
        }

        public List<MaturityRequestView> ListMaturityRequestByCompany(int userID)
        {

            List<MaturityRequestView> newList = new List<MaturityRequestView>();

            using (bati_serverEntities db = new bati_serverEntities())
            {

                var newList2 = (from mr in db.Tbl_MaturityRequests
                                join ak in db.Tbl_AdresKartlari on mr.FirmId equals ak.id
                                select new MaturityRequestView
                                {

                                    CompanyName = ak.musteradi,
                                    RequestId = mr.RequestId,
                                    RequestedDays = mr.RequestedDays,
                                    Description = mr.Description,
                                    RequirerUserId = mr.RequirerUserId,
                                    RequestDate = mr.RequestDate,
                                    DenialMessage = mr.DenialMessage,
                                    ActivityStatus = mr.ActivityStatus,
                                    ApprovalStatus = mr.ApprovalStatus,
                                    ApprovedDate = mr.ApprovedDate,
                                    ApproverUserId = mr.ApproverUserId,
                                    UpdatedDate = mr.UpdatedDate,
                                    FirmId = mr.FirmId,

                                });

                if (userID>0)
                {
                    newList2 = newList2.Where(x => x.RequirerUserId == userID);
                }
                newList = newList2.ToList();
            }
            return newList;

        }
    }
}