using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Controllers;
using TatilSeyahat.Models.Sınıflar;
using PagedList;
using PagedList.Mvc;



namespace TatilSeyahat.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index(int sayfa=1)
        {
            //var bloglar = c.Blogs.OrderByDescending(i => i.ID).ToList();
            //by.Deger1Blog = c.Blogs.OrderByDescending(i => i.ID).ToList();
            //by.Deger1Blog = c.Blogs.OrderByDescending(i => i.ID).ToList().ToPagedList(sayfa,4);

            by.Deger1Blog = c.Blogs.Where(i => i.durum == 1 ).OrderByDescending(i => i.ID).ToList().ToPagedList(sayfa, 4);
            by.Deger3BlogSonCek = c.Blogs.Where(i => i.durum == 1).OrderByDescending(i => i.ID).Take(3).ToList();


            return View(by);
        }

        BlogYorum by = new BlogYorum();
        public ActionResult Detay(int? id,string url)
        {
             
            
           // var blogbul = c.Blogs.Where(x =>   x.ID == id && x.durum==1  ) .ToList();
        
           by.Deger1Blog = c.Blogs.Where(x => x.ID == id && x.durum==1 ).ToList();
            by.Deger2Yorum=c.Yorums.Where(x => x.Blogid == id).ToList();


            return View(by);
        }

        public ActionResult SonBloglar()
        {
            var bloglar = c.Blogs.Where(i => i.durum == 1).OrderByDescending(i => i.ID).Take(3).ToList();
            return View(bloglar);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        
        [HttpPost]
        public PartialViewResult YorumYap(Yorum y, int id)
        {
            c.Yorums.Add(y);
            y.Blogid = id;
            c.SaveChanges();
            

            return PartialView("YorumYap");
        }

        
    }
}