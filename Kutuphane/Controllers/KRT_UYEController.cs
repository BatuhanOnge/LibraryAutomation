using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kutuphane.Models;

namespace Kutuphane.Controllers
{
    public class KRT_UYEController : Controller
    {
        private Entities db = new Entities();

        // GET: KRT_UYE
        public ActionResult Index()
        {
            return View(db.KRT_UYE.ToList());
        }

        // GET: KRT_UYE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KRT_UYE kRT_UYE = db.KRT_UYE.Find(id);
            if (kRT_UYE == null)
            {
                return HttpNotFound();
            }
            return View(kRT_UYE);
        }

        // GET: KRT_UYE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KRT_UYE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UYE_NO,TC,CINSIYET,AD,SOYAD,DOGUM_TARIHI,DOGUM_YERI,MESLEK,MAIL,TELEFON,ADRES,KAYIT_TARIHI")] KRT_UYE kRT_UYE)
        {
            if (ModelState.IsValid)
            {
                db.KRT_UYE.Add(kRT_UYE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kRT_UYE);
        }

        // GET: KRT_UYE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KRT_UYE kRT_UYE = db.KRT_UYE.Find(id);
            if (kRT_UYE == null)
            {
                return HttpNotFound();
            }
            return View(kRT_UYE);
        }

        // POST: KRT_UYE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UYE_NO,TC,CINSIYET,AD,SOYAD,DOGUM_TARIHI,DOGUM_YERI,MESLEK,MAIL,TELEFON,ADRES,KAYIT_TARIHI")] KRT_UYE kRT_UYE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kRT_UYE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kRT_UYE);
        }

        // GET: KRT_UYE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KRT_UYE kRT_UYE = db.KRT_UYE.Find(id);
            if (kRT_UYE == null)
            {
                return HttpNotFound();
            }
            return View(kRT_UYE);
        }

        // POST: KRT_UYE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KRT_UYE kRT_UYE = db.KRT_UYE.Find(id);
            db.KRT_UYE.Remove(kRT_UYE);
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
