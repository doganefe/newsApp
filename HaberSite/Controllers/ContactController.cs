using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using HaberSite.Models;
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace HaberSite.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            string url = "https://www.sozcu.com.tr/sitemap_google_news.xml";

            XmlSerializer ser = new XmlSerializer(typeof(Urlset));

            WebClient client = new WebClient();

            string data = Encoding.Default.GetString(client.DownloadData(url));

            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));

            Urlset reply = (Urlset)ser.Deserialize(stream);

            return Content(reply.urlList[2].image[0].imageloc);
        }
    }
}