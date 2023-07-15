using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSchool.Models.EntityFramework;

namespace MVCSchool.Controllers
{
    public class IletisimController : Controller
    {
        DbMvcSchoolEntities db = new DbMvcSchoolEntities();
        public ActionResult Index()
        {
           
            return View();
        }
    }
}