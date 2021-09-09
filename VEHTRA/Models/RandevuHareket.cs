using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEHTRA.Models
{
    public class RandevuHareket
    {
        [Key]
        public int RandevuId { get; set; }
        public DateTime Tarih { get; set; }

        [StringLength(200)]
        public string Adres { get; set; }
        public int ArabaId { get;set; } 
        public int PersonelId { get; set; }
        public virtual Araba Araba { get; set; } 
        public virtual Personel Personel { get; set; }
    }
}