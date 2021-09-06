using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VEHTRA.Models;

namespace VEHTRA.Controllers
{
    public class TuvTurkController : Controller
    {
        // GET: TuvTurk
        Context c = new Context();
        public ActionResult Index(string p)
        {
            var value = c.TuvTakips.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult YeniTuv()
        {
            List<SelectListItem> p1 = (from x in c.TuvTakips.ToList()
                                       select new SelectListItem
                                       {
                                           Text = x.MuayeneSonucu,
                                           Value = x.Id.ToString()
                                       }).ToList();
            ViewBag.p2 = p1;
            return View();

        }

        [HttpPost]
        public ActionResult YeniTuv(TuvTakip t)
        {
            t.TuvMuayeneSon = DateTime.Parse(DateTime.Now.ToLongTimeString());
            t.TuvMuayeneSonraki = DateTime.Parse(DateTime.Now.ToLongTimeString());
            c.TuvTakips.Add(t);
            c.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult TuvGetir(int id)
        {
            var sg = c.TuvTakips.Find(id);
            return View("TuvGetir", sg);
        }

        public ActionResult TuvGuncelle(TuvTakip t)
        {
            var tuv = c.TuvTakips.Find(t.Id);
            tuv.MuayeneDurumu = t.MuayeneDurumu;
            tuv.MuayeneSonucu = t.MuayeneSonucu;
            tuv.TuvMuayeneSon = t.TuvMuayeneSon;
            tuv.TuvMuayeneSonraki = tuv.TuvMuayeneSonraki;
            tuv.TuvMuayeneUcreti = t.TuvMuayeneUcreti;
            
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Yazdır()
        {
            var value = c.TuvTakips.ToList();
            return View(value);
        }
       

    }
}