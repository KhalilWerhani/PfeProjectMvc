using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PfeProjectMvc.Models;

namespace PfeProjectMvc.Controllers
{
    public class CONGE_LVController : Controller
    {
        private Sco_Entities db = new Sco_Entities();

        // GET: CONGE_LV
        public ActionResult Index()
        {
            return View(db.CONGE_LV.ToList());
        }

        // GET: CONGE_LV/Details/5
        public ActionResult Details(decimal? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONGE_LV cONGE_LV = db.CONGE_LV.Find(id);
            if (cONGE_LV == null)
            {
                return HttpNotFound();
            }
            return View(cONGE_LV);
        }

        // GET: CONGE_LV/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CONGE_LV/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_CONG,NOM,PRENOM,EMAIL,MOTIF_CONGE,DATE_DEP,DATE_RET,TELEPHONE,TYPE_CONGE,STATUT")] CONGE_LV cONGE_LV)
        {
            if (ModelState.IsValid)
            {
                db.CONGE_LV.Add(cONGE_LV);
                db.SaveChanges();
                return RedirectToAction("Conge_sended");
            }

            return View(cONGE_LV);
        }

        // GET: CONGE_LV/Edit/5
        public ActionResult Edit(decimal? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONGE_LV cONGE_LV = db.CONGE_LV.Find(id);
            if (cONGE_LV == null)
            {
                return HttpNotFound();
            }
            return View(cONGE_LV);
        }

        // POST: CONGE_LV/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_CONG,NOM,PRENOM,EMAIL,MOTIF_CONGE,DATE_DEP,DATE_RET,TELEPHONE,TYPE_CONGE,STATUT")] CONGE_LV cONGE_LV)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONGE_LV).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cONGE_LV);
        }

        // GET: CONGE_LV/Delete/5
        public ActionResult Delete(decimal? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONGE_LV cONGE_LV = db.CONGE_LV.Find(id);
            if (cONGE_LV == null)
            {
                return HttpNotFound();
            }
            return View(cONGE_LV);
        }

        // POST: CONGE_LV/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            CONGE_LV cONGE_LV = db.CONGE_LV.Find(id);
            db.CONGE_LV.Remove(cONGE_LV);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Conge_sended()
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
