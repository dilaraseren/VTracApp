using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEHTRA.Models
{
    public class HasarKayit
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string Aciklama { get; set; }
        public decimal Ucret { get; set; }
        [StringLength(100)]
        public string Firma { get; set; }
    }
}