using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VEHTRA.Models;

namespace VEHTRA.Controllers
{
    public class KaskoController : Controller
    {
        // GET: Kasko
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Kaskos.ToList();
            return View(value);
        }
    }
}