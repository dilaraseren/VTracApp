﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEHTRA.Models
{
    public class Kasko
    {
        [Key]
        public int Id { get; set; }
        public DateTime KaskoTarihi { get; set; }
        public decimal KaskoUcreti { get; set; }
        public DateTime KaskoSon { get; set; }
        public DateTime KaskoSonraki { get; set; }
        public bool KaskoDurumu { get; set; }
        public string KaskoSonucu { get; set; }
        public ICollection<Araba> Arabas { get; set; }
    }
}