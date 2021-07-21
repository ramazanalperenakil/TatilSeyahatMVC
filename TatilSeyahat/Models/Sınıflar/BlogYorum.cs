using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Sınıflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1Blog { get; set; } 
        public IEnumerable<Yorum> Deger2Yorum { get; set; }
        public IEnumerable<Blog> Deger3BlogSonCek { get; set; }
        
    }
}