using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEHTRA.Models
{
    public class Detay
    {
        [Key]
        public int DetayId { get; set; }

        [StringLength(200)]
        public string UrunAd { get; set; }

        [StringLength(2000)]
        public string UrunBilgi { get; set; }
    }
}