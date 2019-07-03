using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using HaberSite.Models;

namespace HaberSite.Controllers
{
    public class WeatherController : Controller
    {
        public ActionResult HavaDurumu()
        {
            return View(new hava() { 
                sehirAdi = "Istanbul",
                derece = "32",
                durum = "Parcalı bulutlu",
            });
        }

        [HttpPost]
        public ActionResult HavaDurumu(hava city)
        {
            hava qwe = new hava();
            string sehirAdim = city.sehirAdi;
            if(sehirAdim==null)
            {
                return Content("Sehir adina uygunsuz harfelr girilmiştir");
            }
            string api = "a0db64773ff531987add6fe62ebbbe01";
            string baglanti = "http://api.openweathermap.org/data/2.5/weather?q=" + sehirAdim + "&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument Hava = XDocument.Load(baglanti);
            var sicaklik = Hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var icon = Hava.Descendants("weather").ElementAt(0).Attribute("icon").Value;
            var sehirAdi = Hava.Descendants("city").ElementAt(0).Attribute("name").Value;
            var durum = Hava.Descendants("weather").ElementAt(0).Attribute("value").Value;

            qwe.icon = "http://openweathermap.org/img/w/" + icon + ".png";
            qwe.derece = sicaklik + " ºC";
            qwe.durum = durum;
            qwe.sehirAdi = sehirAdi;
            return View(qwe);
        }
        
    }
}