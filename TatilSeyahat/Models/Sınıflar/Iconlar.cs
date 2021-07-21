using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Sınıflar
{
    public class Iconlar
    {
        [Key]
        public int IconID { get; set; }
        public string IconResim { get; set; }
        public string IcınYazi { get; set; }
    }
}