using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Iletisim
    {
        [Key]
        public int ID { get; set; }
        public string Telefon { get; set; }
        public string Telefon2 { get; set; }
        public string Mail { get; set; }
        public string Yetkili { get; set; }
        public string Konum { get; set; }
        public string Fax { get; set; }
    }
}