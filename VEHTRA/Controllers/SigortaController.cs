using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VEHTRA.Models;

namespace VEHTRA.Controllers
{
    public class SigortaController : Controller
    {
        // GET: Sigorta
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Sigortas.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult YeniSigorta()
        {
            List<SelectListItem> p1 = (from x in c.Sigortas.ToList()
                                       select new SelectListItem
                                       {
                                           Text = x.SigortaSonucu,
                                           Value = x.Id.ToString()
                                       }).ToList();
            ViewBag.p2 = p1;
            return View();

        }

        [HttpPost]
        public ActionResult YeniSigorta(Sigorta s)
        {
            s.SigortaSon = DateTime.Parse(DateTime.Now.ToLongTimeString());
            s.SigortaSon = DateTime.Parse(DateTime.Now.ToLongTimeString());
            c.Sigortas.Add(s);
            c.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult SigortaGetir(int id)
        {
            var sg = c.Sigortas.Find(id);
            return View("SigortaGetir", sg);
        }

        public ActionResult SigortaGuncelle(Sigorta s)
        {
            var sg = c.Sigortas.Find(s.Id);
            sg.SigortaDurumu = s.SigortaDurumu;
            sg.SigortaSon = s.SigortaSon;
            sg.SigortaSonraki = s.SigortaSonraki;
            sg.SigortaSonucu = s.SigortaSonucu;
            sg.SigortaTarihi = s.SigortaTarihi;
            sg.SigortaUcreti = s.SigortaUcreti;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Yazdır()
        {
            var value = c.Sigortas.ToList();
            return View(value);
        }

    }
}