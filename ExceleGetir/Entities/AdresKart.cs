using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ExceleGetir.Models;

namespace ExceleGetir.Entities
{

    public interface IAdresKart
    {

        void AddToBlackList(Tbl_AdresKartlari adreskart);
        void UpdateAdreskart(Tbl_AdresKartlari adreskart);
        void DeleteAdreskart(int id);
        Tbl_AdresKartlari GetAdreskart(int id);
        List<Tbl_AdresKartlari> ListAllAdreskart();
        void AddToBlackListNote(Tbl_BlacklistNotes blnote);
        Tbl_BlacklistNotes GetBlNote(int id);
        List<Tbl_BlacklistNotes> ListAllBlNotes();


    }

    public class AdresKart : IAdresKart
    {
        public void DeleteAdreskart(int id)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {

                var deletedAdreskart = db.Tbl_AdresKartlari.SingleOrDefault(x => x.id == id);
                
                db.Entry(deletedAdreskart).State = EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void UpdateAdreskart(Tbl_AdresKartlari adreskart)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {
                //context üretmedik çünkü contextimiz burda db
                var updatedAdreskart = db.Entry(adreskart);
               
                updatedAdreskart.State = EntityState.Modified;
                db.SaveChanges();

            }
        }


        //public bool UpdateAdreskartwithID(int ID)
        //{
        //    using (bati_serverEntities db = new bati_serverEntities())
        //    {

        //        var guncellenecek = db.Tbl_AdresKartlari.Where(x => x.id == ID).SingleOrDefault();

        //        if (guncellenecek.IsActive == true)
        //        {
        //            guncellenecek.IsActive = false;
        //            db.SaveChanges();
        //            return false;
        //        }
        //        else
        //        {
        //            guncellenecek.IsActive = true;
        //            db.SaveChanges();
        //            return true;
        //        }

        //    }
        //}

        public void AddToBlackList(Tbl_AdresKartlari adreskart)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {
                var AddedAdreskart = db.Entry(adreskart);
                AddedAdreskart.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public Tbl_AdresKartlari GetAdreskart(int id)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {
                Tbl_AdresKartlari selectedAdreskart = db.Tbl_AdresKartlari.SingleOrDefault(x => x.id == id);
                return selectedAdreskart;
            }
        }

        public List<Tbl_AdresKartlari> ListAllAdreskart()
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {

                return db.Tbl_AdresKartlari.ToList();

            }
        }
        public void AddToBlackListNote(Tbl_BlacklistNotes blnote)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {
                var AddedBlNote = db.Entry(blnote);
                AddedBlNote.State = EntityState.Added;
                db.SaveChanges();
            }
        }
        public Tbl_BlacklistNotes GetBlNote(int userid)
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {
                Tbl_BlacklistNotes selectedBlNote = db.Tbl_BlacklistNotes.SingleOrDefault(x => x.AddedUserId == userid);
                return selectedBlNote;
            }
        }

        public List<Tbl_BlacklistNotes> ListAllBlNotes()
        {
            using (bati_serverEntities db = new bati_serverEntities())
            {

                return db.Tbl_BlacklistNotes.ToList();

            }
        }
    }
}