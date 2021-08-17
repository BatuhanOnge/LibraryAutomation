using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kutuphane.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kitaplar()
        {
            return View();
        }

        public ActionResult Hareketler()
        {
            return View();
        }
        public ActionResult Uyeler()
        {
            return View();
        }
        public ActionResult YeniUye()
        {
            return View();
        }
        public ActionResult YeniKitap()
        {
            return View();
        }
    }
}