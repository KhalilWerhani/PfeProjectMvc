using PfeProjectMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PfeProjectMvc.Controllers
{
    public class TreatMissionController : Controller
    {
         Sco_Entities  db = new Sco_Entities();

        // GET: MISSION
        public ActionResult Index(string searching)
        {
            Console.WriteLine(searching);
            using ( db = new Sco_Entities())
            {
                return View(db.MISSIONs.Where(x => x.NOM.Contains(searching) || searching == null).ToList());
                Console.WriteLine(db.MISSIONs.Where(x => x.NOM.Contains(searching) || searching == null).ToList());
            }
        }

        // GET: MISSION/Details/5
        public ActionResult Details(int? id)
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

        // GET: MISSION/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MISSION/Create
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

            return View(mISSION);
        }

        // GET: MISSION/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id < 0)
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

        // POST: MISSION/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NOM,PRÉNOM,N__PASSEPORT,NATIONALITÉ,FONCTION,TITRE_EQUIPE,MOTIF_DE_MISSION,INTITULÉ_DE_MISSION,DATE__DÉPART,DATE_RETOUR,OBJET_DE_MISSION,TELEPHONE,EMAIL,STATUS")] MISSION mISSION)
        {

            if (ModelState.IsValid)
            {
                db.Entry(mISSION).State = EntityState.Modified;
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    //throw;
                }
                //dbc.SaveChanges();
                System.Threading.Thread.Sleep(200);
                return RedirectToAction("Index");
                //    db.Entry(mISSION).State = EntityState.Modified;
                //    db.SaveChanges();
                //    return RedirectToAction("Index");
                //}
                //return View(mISSION);
            }

            return View(mISSION);
        }

        // GET: MISSION/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: MISSION/Delete/5
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
