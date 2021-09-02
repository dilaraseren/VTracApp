using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEHTRA.Models
{
    public class Sigorta
    {
        [Key]
        public int Id { get; set; }

        public DateTime SigortaTarihi { get; set; }
        public decimal SigortaUcreti { get; set; }

        public DateTime SigortaSon { get; set; }
        public DateTime SigortaSonraki { get; set; }

        public bool SigortaDurumu { get; set; }

        [StringLength(500)]
        public string SigortaSonucu { get; set; }

        public ICollection<Araba> Arabas { get; set; }


    }
}