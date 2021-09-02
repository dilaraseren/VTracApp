using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VEHTRA.Models
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string PersonelGorseli { get; set; }

        [StringLength(200)]
        public string About { get; set; }



        [StringLength(15)]
        public string Telefon { get; set; }
        public int DepartmanId { get; set; }
        public virtual Departman Departman { get; set; }

    }
}