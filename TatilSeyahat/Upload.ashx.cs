using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahat
{
    /// <summary>
    /// Upload için özet açıklama
    /// </summary>
    public class Upload : IHttpHandler
    {

        //public void ProcessRequest(HttpContext context)
        //{
        //    context.Response.ContentType = "text/plain";
        //    context.Response.Write("Merhaba Dünya");
        //}

        public void ProcessRequest(HttpContext context)
        {
            HttpPostedFile uploads = context.Request.Files["upload"];
            string CKEditorFuncNum = context.Request["CKEditorFuncNum"];
            string file = System.IO.Path.GetFileName(DateTime.Now.Ticks.ToString() + "_" + uploads.FileName);

            uploads.SaveAs(context.Server.MapPath(".") + "\\../Images\\" + file);

            //provide direct URL here
            string url = "https://localhost:44368/Images/" + file;

            context.Response.Write("<script>window.parent.CKEDITOR.tools.callFunction(" + CKEditorFuncNum + ", \"" + url + "\");</script>");
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}