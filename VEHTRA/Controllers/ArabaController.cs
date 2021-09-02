using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VEHTRA.Models;

namespace VEHTRA.Controllers
{
    public class ArabaController : Controller
    {
        // GET: Araba
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Arabas.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult YeniArac()
        {
            List<SelectListItem> p1 = (from x in c.Arabas.ToList()
                                       select new SelectListItem
                                       {
                                           Text = x.Model,
                                           Value = x.Id.ToString()
                                       }).ToList();
            ViewBag.p2 = p1;
            return View();

        }

        [HttpPost]
        public ActionResult YeniArac(Araba p)
        {
            p.AlisTarihi = DateTime.Parse(DateTime.Now.ToLongTimeString());
            p.TeslimTarihi = DateTime.Parse(DateTime.Now.ToLongTimeString());
            c.Arabas.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult AracGetir(int id)
        {
            var arc = c.Arabas.Find(id);
            return View("AracGetir", arc);
        }

        public ActionResult AracGuncelle(Araba a)
        {
            var arc = c.Arabas.Find(a.Id);
            arc.Plaka = a.Plaka;
            arc.Model = a.Model;
            arc.RuhsatNo = a.RuhsatNo;
            arc.AlisTarihi = a.AlisTarihi;
            arc.TeslimTarihi = a.TeslimTarihi;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}