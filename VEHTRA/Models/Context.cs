using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VEHTRA.Models
{
    public class Context:DbContext
    {
        public DbSet<Araba> Arabas { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<TuvTakip> TuvTakips { get; set; }
        public DbSet<Kasko> Kaskos { get; set; }
        public DbSet<Sigorta> Sigortas { get; set; }
        public DbSet<Departman> Departmen { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<RandevuHareket> RandevuHarekets { get; set; } 
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<FaturaKalem> FaturaKalems { get; set; }
        public DbSet<HasarKayit> HasarKayits { get; set; }
        public DbSet<Detay> Detays { get; set; }
    }
}