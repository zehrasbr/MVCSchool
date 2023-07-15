using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSchool.Models.EntityFramework;

namespace MVCSchool.Controllers
{
    public class KulupController : Controller
    {
        DbMvcSchoolEntities db = new DbMvcSchoolEntities();
        public ActionResult Index()
        {
            var kulup = db.TBLKULUPLER.ToList();
            return View(kulup);
        }

        [HttpGet]
        public ActionResult YeniKulup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKulup(TBLKULUPLER p)
        {
            db.TBLKULUPLER.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}