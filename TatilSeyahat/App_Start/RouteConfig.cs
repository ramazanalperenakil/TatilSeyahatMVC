using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TatilSeyahat
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
              name: "Anasayfa",
              url: "",
              defaults: new { controller = "Home", action = "Default", id = UrlParameter.Optional }
          );
            routes.MapRoute(
                name: "Default",
                url: "Anasayfa",
                defaults: new { controller = "Home", action = "Default", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Iconlar",
               url: "Iconlar",
               defaults: new { controller = "Home", action = "Iconlar", id = UrlParameter.Optional }
           );

            routes.MapRoute(
           name: "AnasayfaHakkimizda",
           url: "AnasayfaHakkimizda",
           defaults: new { controller = "Home", action = "AnasayfaHakkimizda", id = UrlParameter.Optional }
       );


            routes.MapRoute(
    name: "iletişim",
    url: "iletisim",
    defaults: new { controller = "Iletisim", action = "Index", id = UrlParameter.Optional }
);


            routes.MapRoute(
   name: "AnasayfaBlogSolİkili",
   url: "AnasayfaBlogSolİkili",
   defaults: new { controller = "Home", action = "AnasayfaBlogSolİkili", id = UrlParameter.Optional }
);







                routes.MapRoute(
    name: "SonOnBLog",
    url: "SonOnBLog",
    defaults: new { controller = "Home", action = "SonOnBLog", id = UrlParameter.Optional }
    );
                routes.MapRoute(
    name: "SonOnBLogAltili",
    url: "SonOnBLogAltili",
    defaults: new { controller = "Home", action = "SonOnBLogAltili", id = UrlParameter.Optional }
    );
                            routes.MapRoute(
    name: "SonOnBLogUclu",
    url: "SonOnBLogUclu",
    defaults: new { controller = "Home", action = "SonOnBLogUclu", id = UrlParameter.Optional }
    );





            routes.MapRoute(
                name: "Blog",
                url: "Blog",
                defaults: new { controller = "Blog", action = "Index" }
            );





            routes.MapRoute(
              name: "SonBlogParçala",
              url: "Son",
              defaults: new { controller = "Blog", action = "SonBloglar" }
          );

            routes.MapRoute(
               name: "Hakkımızda",
               url: "Hakkimizda",
               defaults: new { controller = "About", action = "Index" }
           );

            routes.MapRoute(
                name: "BlogDetay",
                url: "Makale/{baslik}-{id}",
                defaults: new { controller = "Blog", action = "Detay", id = UrlParameter.Optional }
            );

            routes.MapRoute(
             name: "Admin",
             url: "Admin",
             defaults: new { controller = "Admin", action = "Index" }
         );

            routes.MapRoute(
         name: "YorumYap",
         url: "Blog/YorumYap",
         defaults: new { controller = "Blog", action = "YorumYap" }
     );


            routes.MapRoute(
        name: "Yorumşar",
        url: "Admin/Yorumlar",
        defaults: new { controller = "Admin", action = "YorumListele", id = UrlParameter.Optional }
    );




            routes.MapRoute(
              name: "YorumSil",
              url: "Admin/YorumSil/{id}",
              defaults: new { controller = "Admin", action = "YorumSil", id = UrlParameter.Optional }
          );

            routes.MapRoute(
            name: "BlogSil",
            url: "Admin/BlogSil/{id}",
            defaults: new { controller = "Admin", action = "BlogSil", id = UrlParameter.Optional }
        );



            routes.MapRoute(
          name: "BlogEkle",
          url: "Admin/YeniBlog",
          defaults: new { controller = "Admin", action = "YeniBlog", id = UrlParameter.Optional }
      );

            routes.MapRoute(
           name: "BlogGetir",
           url: "Admin/BlogGetir/{id}",
           defaults: new { controller = "Admin", action = "BlogGetir", id = UrlParameter.Optional }
       );


            routes.MapRoute(
 name: "Hakkımızdadmina",
 url: "Admin/Hakkimizda",
 defaults: new { controller = "Admin", action = "Hakkimizda", id = UrlParameter.Optional }
);






            routes.MapRoute(
          name: "BlogGuncelle",
          url: "Admin/BlogGuncelle/{id}",
          defaults: new { controller = "Admin", action = "BlogGuncelle", id = UrlParameter.Optional }
      );

            
            routes.MapRoute(
          name: "HakkimizdaGuncelle",
          url: "Admin/HakkimizdaGuncelle/{id}",
          defaults: new { controller = "Admin", action = "HakkimizdaGuncelle", id = UrlParameter.Optional }
      );



            routes.MapRoute(
   name: "YorumGetir",
   url: "Admin/YorumGetir/{id}",
   defaults: new { controller = "Admin", action = "YorumGetir", id = UrlParameter.Optional }
);




            routes.MapRoute(
          name: "YorumGuncelles",
          url: "Admin/YorumGuncelle/{id}",
          defaults: new { controller = "Admin", action = "YorumGuncelle", id = UrlParameter.Optional }
      );



        }
    }
}
