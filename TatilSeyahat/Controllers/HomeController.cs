using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Sınıflar;

namespace TatilSeyahat.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        public ActionResult Default()
        {
            var bloglar = c.Blogs.Where(i => i.durum == 1).OrderByDescending(i => i.ID).Take(5).ToList();


            //c.Blogs.OrderByDescending(i => i.ID  ).Take(5).ToList();
            return View(bloglar);
        }


        public ActionResult Iconlar()
        {
            var iconlar = c.Iconlars.ToList();
            return View(iconlar);
        }

        public ActionResult AnasayfaHakkimizda()
        {
            var AnasayfaHakkimizda = c.Anasayfas.ToList();
            return View(AnasayfaHakkimizda);
        }

        public PartialViewResult AnasayfaBlogSolİkili()
        {
            var AnasayfaBlogSolİkili = c.Blogs.Where(i => i.durum == 1).OrderByDescending(i => i.ID).Take(3).ToList();
            return PartialView(AnasayfaBlogSolİkili);
        }

       

      

        public PartialViewResult SonOnBLog()
        {
            var SonOnBLogCek = c.Blogs.Where(i => i.durum == 1).OrderByDescending(i => i.ID).Take(10).ToList();
            return PartialView(SonOnBLogCek);
        }

        public PartialViewResult SonOnBLogAltili()
        {
            var SonOnBLogAltili = c.Blogs.Where(i => i.durum == 1).OrderByDescending(i => i.ID).Take(3).ToList();
            return PartialView(SonOnBLogAltili);
        }

        public PartialViewResult SonOnBLogUclu()
        {
            var SonOnBLogUclu = c.Blogs.Where(i => i.durum == 1).OrderByDescending(i => i.ID).Take(3).ToList();
            return PartialView(SonOnBLogUclu);
        }




    }
}