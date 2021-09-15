using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VEHTRA.Models;

namespace VEHTRA.Controllers
{
    public class HasarKayitController : Controller
    {
        // GET: HasarKayit
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.HasarKayits.ToList();
            return View(deger);
        }
    }
}