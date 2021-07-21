using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Sınıflar
{
    public class iletisim
    {
        [Key]
        public int ID { get; set; }
        public String AdSoyad { get; set; }
        public String Mail { get; set; }
        public String Konu { get; set; }
        public String Mesaj { get; set; }
    }
}