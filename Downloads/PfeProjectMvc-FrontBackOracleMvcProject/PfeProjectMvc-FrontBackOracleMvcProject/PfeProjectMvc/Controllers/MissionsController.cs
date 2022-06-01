using PfeProjectMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PfeProjectMvc.Controllers
{
    public class MissionsController : Controller
    {

        private Sco_Entities db = new Sco_Entities();

        // GET: DEMANDEMISSION
        public ActionResult Index()
        {
            return View();
        }

        // GET: DEMANDEMISSION/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MISSION mISSION = db.MISSIONs.Find(id);
            if (mISSION == null)
            {
                return HttpNotFound();
            }
            return View(mISSION);
        }

        // GET: DEMANDEMISSION/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DEMANDEMISSION/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NOM,PRÉNOM,N__PASSEPORT,NATIONALITÉ,FONCTION,TITRE_EQUIPE,MOTIF_DE_MISSION,INTITULÉ_DE_MISSION,DATE__DÉPART,DATE_RETOUR,OBJET_DE_MISSION,TELEPHONE,EMAIL,STATUS")] MISSION mISSION)
        {
            if (ModelState.IsValid)
            {
                db.MISSIONs.Add(mISSION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        // GET: DEMANDEMISSION/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MISSION mISSION = db.MISSIONs.Find(id);
            if (mISSION == null)
            {
                return HttpNotFound();
            }
            return View(mISSION);
        }

        // POST: DEMANDEMISSION/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NOM,PRÉNOM,N__PASSEPORT,NATIONALITÉ,FONCTION,TITRE_EQUIPE,MOTIF_DE_MISSION,INTITULÉ_DE_MISSION,DATE__DÉPART,DATE_RETOUR,OBJET_DE_MISSION,TELEPHONE,EMAIL,STATUS")] MISSION mISSION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mISSION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mISSION);
        }

        // GET: DEMANDEMISSION/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MISSION mISSION = db.MISSIONs.Find(id);
            if (mISSION == null)
            {
                return HttpNotFound();
            }
            return View(mISSION);
        }

        // POST: DEMANDEMISSION/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            MISSION mISSION = db.MISSIONs.Find(id);
            db.MISSIONs.Remove(mISSION);
            db.SaveChanges();
            return RedirectToAction("Index");
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
