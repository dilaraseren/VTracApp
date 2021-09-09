using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEHTRA.Models
{
    public class Araba
    {
        [Key]
        public int Id { get; set; }

        [StringLength(15)]
        public string Plaka { get; set; }

        [StringLength(17)]
        public string VIN { get; set; } //motor sase numarası

        [StringLength(10)]
        public string RuhsatNo { get; set; }

        [StringLength(100)]
        public string Model { get; set; }

        [StringLength(100)]
        public string Marka { get; set; }

        [StringLength(100)]
        public string Cins { get; set; }

        [StringLength(100)]
        public string YakitCinsi { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public bool Durum { get; set; }
        public int TuvTakipId { get; set; }
        public int SigortaId { get; set; }
        public int KaskoId { get; set; }
        public virtual Sigorta Sigorta { get; set; }
        public virtual TuvTakip TuvTakip { get; set; }
        public virtual Kasko Kasko { get; set; }


    }
}