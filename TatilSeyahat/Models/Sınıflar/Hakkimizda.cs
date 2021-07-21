using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Sınıflar
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public String Baslik { get; set; }
        public String Aciklama { get; set; }
        public String FotoUrl { get; set; }
    }
}