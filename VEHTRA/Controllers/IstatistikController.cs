using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VEHTRA.Models;

namespace VEHTRA.Controllers
{
    public class IstatistikController : Controller
    {
        // GET: Istatistik
        Context c = new Context();

        public ActionResult Index()
        {
            var deger1 = c.Arabas.Count().ToString();
            ViewBag.d1 = deger1;
            var deger2 = c.Personels.Count().ToString();
            ViewBag.d2 = deger2;
            var deger3 = c.Departmen.Count().ToString();
            ViewBag.d3 = deger3;
            var deger4 = c.RandevuHarekets.Count().ToString();
            ViewBag.d4 = deger4;
            var deger5 = c.TuvTakips.Sum(x => x.TuvMuayeneUcreti).ToString();
            ViewBag.d5 = deger5;
            var deger6 = c.Kaskos.Sum(x => x.KaskoUcreti).ToString();
            ViewBag.d6 = deger6;
            var deger7 = c.Sigortas.Sum(x => x.SigortaUcreti).ToString();
            ViewBag.d7 = deger7;


            DateTime bugun = DateTime.Today;
            var deger15 = c.RandevuHarekets.Count(x => x.Tarih == bugun).ToString();
            ViewBag.d15 = deger15;


            return View();
        }



        public ActionResult KolayTablolar()
        {
            var sorgu = from x in c.Personels
                        group x by x.Departman.DepartmanAd into g
                        select new SinifGrup
                        {
                            Personel = g.Key,
                            Sayi = g.Count()
                        };

            return View(sorgu.ToList());
        }

        public PartialViewResult Partial1()
        {
            var sorgu2 = from x in c.Personels
                         group x by x.Departman.DepartmanAd into g
                         select new SinifGrup2
                         {
                             Departman = g.Key,
                             Sayi = g.Count()
                         };

            return PartialView(sorgu2.ToList());
        }
        public PartialViewResult Partial2()
        {
            var sorgu = c.Personels.ToList();
            return PartialView(sorgu);
        }

        public PartialViewResult Partial3()
        {
            var sorgu = c.Arabas.ToList();
            return PartialView(sorgu);
        }

        public PartialViewResult Partial4()
        {
            var sorgu = from x in c.Arabas
                        group x by x.Model into g
                        select new SinifGrup3
                        {
                            Araba = g.Key,
                            sayi = g.Count()
                        };

            return PartialView(sorgu.ToList());
        }

        //public PartialViewResult Partial5()
        //{
        //    var sorgu = c.Kategoris.ToList();
        //    return PartialView(sorgu);
        //}
    }
}