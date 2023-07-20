using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSchool.Models.EntityFramework;

namespace MVCSchool.Controllers
{
    public class OgrenciController : Controller
    {
        DbMvcSchoolEntities db = new DbMvcSchoolEntities();
        public ActionResult Index()
        {
            var ogrenciler = db.TBLOGRENCILER.ToList();
            return View(ogrenciler);
        }
        [HttpGet]
        public ActionResult YeniOgrenci() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniOgrenci(TBLOGRENCILER p)
        {
            db.TBLOGRENCILER.Add(p);
            db.SaveChanges();
            return View();
        }

    }
}