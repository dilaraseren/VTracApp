using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VEHTRA.Models
{
    public class ArabaDetay
    {
        public IEnumerable<Araba> Deger1 { get; set; }
        public IEnumerable<Detay> Deger2 { get; set; }
    }
}