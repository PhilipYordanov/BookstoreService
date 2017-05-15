using BookstoreWebForms.BookstoreService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookstoreWebForms
{
    /// <summary>
    /// Summary description for Cover
    /// </summary>
    public class Cover : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var client = new BooksServiceClient();
            var book = client.GetBook(Convert.ToInt32(context.Request.QueryString["id"]));
            context.Response.OutputStream.Write(book.Cover, 0, book.Cover.Length);
            context.Response.ContentType = "image/jpeg";
            client.Close();
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