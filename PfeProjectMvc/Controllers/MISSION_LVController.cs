using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PfeProjectMvc.Models;
using System.Data.Entity.Validation;

namespace PfeProjectMvc.Controllers
{
    public class MISSION_LVController : Controller
    {
        private Sco_Entities db = new Sco_Entities();

        // GET: MISSION_LV
        public ActionResult Index(string searching)
        {
            Console.WriteLine(searching);
            using (Sco_Entities db = new Sco_Entities())
            {
                return View(db.MISSION_LV.Where(x => x.NOM.Contains(searching) || searching == null).ToList());
                Console.WriteLine(db.MISSION_LV.Where(x => x.NOM.Contains(searching) || searching == null).ToList());
            }
        }
        //public ActionResult Index()
        //{

        //    return View(db.MISSION_LV.ToList());
        //}

        // GET: MISSION_LV/Details/5
        public ActionResult Details(decimal? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MISSION_LV mISSION_LV = db.MISSION_LV.Find(id);
            if (mISSION_LV == null)
            {
                return HttpNotFound();
            }
            return View(mISSION_LV);
        }

        // GET: MISSION_LV/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MISSION_LV/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_MISS,NOM,PRENOM,EMAIL,FONCTION,MOTIF_MISS,DATE_DEP,DATE_RET,TELEPHONE,STATUT")] MISSION_LV mISSION_LV)
        {
            if (ModelState.IsValid)
            {
                db.MISSION_LV.Add(mISSION_LV);
                //try
                //{
                //    // Your code...
                //    // Could also be before try if you know the exception occurs in SaveChanges

                //    db.SaveChanges();
                //}
                //catch (DbEntityValidationException e)
                //{
                //    foreach (var eve in e.EntityValidationErrors)
                //    {
                //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                //        foreach (var ve in eve.ValidationErrors)
                //        {
                //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                //                ve.PropertyName, ve.ErrorMessage);
                //        }
                //    }
                //    throw;
                db.SaveChanges();
                return RedirectToAction("Mission_sended");

            }
            return View(mISSION_LV);
            
        }
        

        // GET: MISSION_LV/Edit/5
        public ActionResult Edit(decimal? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MISSION_LV mISSION_LV = db.MISSION_LV.Find(id);
            if (mISSION_LV == null)
            {
                return HttpNotFound();
            }
            return View(mISSION_LV);
        }

        // POST: MISSION_LV/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_MISS,NOM,PRENOM,EMAIL,FONCTION,MOTIF_MISS,DATE_DEP,DATE_RET,TELEPHONE,STATUT")] MISSION_LV mISSION_LV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mISSION_LV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mISSION_LV);
        }

        // GET: MISSION_LV/Delete/5
        public ActionResult Delete(decimal? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MISSION_LV mISSION_LV = db.MISSION_LV.Find(id);
            if (mISSION_LV == null)
            {
                return HttpNotFound();
            }
            return View(mISSION_LV);
        }

        // POST: MISSION_LV/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            MISSION_LV mISSION_LV = db.MISSION_LV.Find(id);
            db.MISSION_LV.Remove(mISSION_LV);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

      
        public ActionResult Mission_sended()
        {

            return View();
        }

      

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
