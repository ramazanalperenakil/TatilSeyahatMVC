using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TatilSeyahat.Models.Sınıflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public String Baslik { get; set; }
        public DateTime Time { get; set; }

        [AllowHtml]
        public String Aciklama { get; set; }
        public String BlogImage { get; set; }
        public string SeoUrl { get; set; }
        public int durum { get; set; }

        public ICollection<Yorum> Yorums { get; set; }

    }
}