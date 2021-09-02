using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEHTRA.Models
{
    public class TuvTakip
    {
        [Key]
        public int Id { get; set; }

        public DateTime TuvMuayeneSon { get; set; }
        public DateTime TuvMuayeneSonraki { get; set; }

        public bool MuayeneDurumu { get; set; }

        [StringLength(500)]
        public string MuayeneSonucu { get; set; }
        public decimal TuvMuayeneUcreti { get; set; }

        public ICollection<Araba> Arabas { get; set; }

    }
}