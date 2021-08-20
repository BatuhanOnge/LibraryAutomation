using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kutuphane.Models;

namespace Kutuphane.Controllers
{
    public class KitapController : Controller
    {
        Model1 db = new Model1();
        // GET: Uye
        public ActionResult Index()
        {
            
            try
            {
                var result = db.KRT_KITAP.ToList();
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
        public ActionResult KitapEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KitapEkle(KRT_KITAP newMemberData)
        {
            db.KRT_KITAP.Add(newMemberData);
            db.SaveChanges();
            return View();
        }

        public ActionResult Sil(int id)
        {
            var ISBN = db.KRT_KITAP.Find(id);
            db.KRT_KITAP.Remove(ISBN);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KitapGuncelle(int id)
        {
            var uyeID = db.KRT_KITAP.Find(id);
            return View("KitapGuncelle", uyeID);
        }
    }
}