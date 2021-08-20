using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kutuphane.Models;

namespace Kutuphane.Controllers
{
    public class UyeController : Controller
    {
        Model1 db = new Model1();
        // GET: Uye
        public ActionResult Index()
        {
            
            try
            {
                var result = db.KRT_UYE.ToList();
                return View(result);
            }
            catch
            {
                return View();
            }
            //finally
            //{
            //    db.Dispose;
            //}
        }
        
        [HttpGet]
        public ActionResult UyeEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UyeEkle(KRT_UYE newMemberData)
        {
            db.KRT_UYE.Add(newMemberData);
            db.SaveChanges();
            return View();
        }

        public ActionResult Sil(int id)
        {
            var uyeID = db.KRT_UYE.Find(id);
            db.KRT_UYE.Remove(uyeID);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UyeGuncelle(int id)
        {
            var uyeID = db.KRT_UYE.Find(id);
            return View("UyeGuncelle", uyeID);
        }
    }
}