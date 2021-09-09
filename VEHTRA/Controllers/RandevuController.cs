using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VEHTRA.Models;

namespace VEHTRA.Controllers
{
    public class RandevuController : Controller
    {
        // GET: Randevu
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.RandevuHarekets.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniRandevu()
        {
            List<SelectListItem> deger1 = (from x in c.Arabas.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Marka,
                                               Value = x.Id.ToString()
                                           }).ToList();


           

            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.FullName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
           
            ViewBag.dgr3 = deger3;


            return View();
        }

        [HttpPost]
        public ActionResult YeniRandevu(RandevuHareket r)
        {
            r.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.RandevuHarekets.Add(r);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RandevuGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in c.Arabas.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Marka,
                                               Value = x.Id.ToString()
                                           }).ToList();



            List<SelectListItem> deger3 = (from x in c.Personels.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.FullName,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            
            ViewBag.dgr3 = deger3;
            var deger = c.RandevuHarekets.Find(id);
            return View("RandevuGetir", deger);
        }

        public ActionResult RandevuGuncelle(RandevuHareket p)
        {
            var deger = c.RandevuHarekets.Find(p.RandevuId);
          
            deger.PersonelId = p.PersonelId;
            deger.Tarih = p.Tarih;
            deger.ArabaId = p.ArabaId;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult RandevuDetay(int id)
        {
            var degerler = c.RandevuHarekets.Where(x => x.RandevuId == id).ToList();
            return View(degerler);
        }
    }
}