﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kutuphane.Models;

namespace Kutuphane.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        public ActionResult Index()
        {
            Model1 db = new Model1();
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
    }
}