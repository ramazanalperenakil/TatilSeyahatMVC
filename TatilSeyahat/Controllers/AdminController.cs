using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Sınıflar;
using PagedList;
using PagedList.Mvc;
using System.IO;
using System.Text.RegularExpressions;

namespace TatilSeyahat.Controllers
{
    public class AdminController : Controller
    {

        // GET: Admin
        Context c = new Context();
        public ActionResult Index(/*int sayfa = 1*/)
        {
            var degerler = c.Blogs.OrderByDescending(i => i.ID).ToList();
            //var bloglar = c.Blogs.OrderByDescending(i => i.ID).ToList()/*.ToPagedList(sayfa, 4)*/;
            

            return View(degerler);

        }

        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            ViewBag.Success = "SilT";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]

        public ActionResult YeniBlog(Blog p)
        {
            try
            {
                if (Request.Files.Count > 0)
                {
                    string dosyaadi = seo1.AdresDuzenle(p.Baslik) + "-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm") + "-" + Path.GetFileName(Request.Files[0].FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                    string yol = "~/uploads/" + dosyaadi /*+ uzanti*/;
                    Request.Files[0].SaveAs(Server.MapPath(yol));
                    p.BlogImage = dosyaadi /*+ uzanti*/;
                    //p.SeoUrl = seo1.AdresDuzenle(p.Baslik);
                    p.Time = DateTime.Now;
                    p.durum = 1;
                    c.Blogs.Add(p);
                    c.SaveChanges();

                    ViewBag.Success = "KayıtT";
                    ModelState.Clear();

                }
                else
                {
                    ViewBag.Error = "KayıtF";
                }


            }
            catch
            {
                ViewBag.Error = "KayıtF";

            }
            return View();

        }

        public ActionResult BlogGetir(int id)
        {
            var b1 = c.Blogs.Find(id);
            return View("BlogGetir", b1);

        }
        [ValidateInput(false)]
        public ActionResult BlogGuncelle(Blog b, HttpPostedFileBase Yuklenecek, int id )
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.Time = b.Time;
            blg.SeoUrl = seo1.AdresDuzenle(b.Baslik);
            blg.durum = b.durum;
            HttpPostedFileBase photo = Request.Files["BlogImage"];
            if (photo != null && photo.ContentLength > 0)
            {
                string dosyaadi = seo1.AdresDuzenle(blg.Baslik) + "-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm") + "-" + Path.GetFileName(photo.FileName);
                    string uzanti = Path.GetExtension(Request.Files[0].FileName);
                   string yol = "~/uploads/" + dosyaadi /*+ uzanti*/;
                   Request.Files[0].SaveAs(Server.MapPath(yol));
                   blg.BlogImage = dosyaadi /*+ uzanti*/;

                  b.BlogImage = blg.BlogImage;

                  c.SaveChanges();
            }
            c.SaveChanges();
            //ViewBag.Success = "GuncelleT";
            TempData["Başarılı"] = "OK";
            //TempData["Hata"] = "NO";
            return RedirectToAction("Index");
            //var b1 = c.Blogs.Find(id);
            //return View("BlogGetir", b1);
        }

        public ActionResult Hakkimizda()
        {
            var b1 = c.Hakkimizdas.First();
            return View("Hakkimizda", b1);
        }


        [ValidateInput(false)]
        public ActionResult HakkimizdaGuncelle(Hakkimizda b)
        {
            var blg = c.Hakkimizdas.First();
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            
           
            HttpPostedFileBase photo = Request.Files["BlogImage"];
            if (photo != null && photo.ContentLength > 0)
            {
                string dosyaadi = seo1.AdresDuzenle(blg.Baslik) + "-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm") + "-" + Path.GetFileName(photo.FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "~/uploads/" + dosyaadi /*+ uzanti*/;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                blg.FotoUrl = dosyaadi /*+ uzanti*/;

                b.FotoUrl = blg.FotoUrl;

                c.SaveChanges();
            }
            c.SaveChanges();
            //ViewBag.Success = "GuncelleT";
            TempData["Başarılı"] = "OK";
            //TempData["Hata"] = "NO";
            return RedirectToAction("Hakkimizda");
            //var b1 = c.Blogs.Find(id);
            //return View("BlogGetir", b1);
        }


        public ActionResult YorumListele()
        {
            var yorumlar = c.Yorums.OrderByDescending(i => i.ID).ToList();
            return View(yorumlar);

        }


        public ActionResult YorumSil(int id)
        {
            var b = c.Yorums.Find(id);
            c.Yorums.Remove(b);
            c.SaveChanges();
            ViewBag.Success = "SilT";
            return RedirectToAction("YorumListele");
        }


        public ActionResult YorumGetir(int id)
        {
            var y = c.Yorums.Find(id);
            return View("YorumGetir", y);
        }

        public ActionResult YorumGuncelle(Yorum b )
        {
            var yrm = c.Yorums.First();
            yrm.KullaniciAdi = b.KullaniciAdi;
            yrm.Mail = b.Mail;
            yrm.Yorumunuz = b.Yorumunuz;
            c.SaveChanges();
            TempData["Başarılı"] = "OK";
            return RedirectToAction("YorumListele");
            
        }
    }
}