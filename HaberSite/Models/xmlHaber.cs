using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace HaberSite.Models
{
    [Serializable()]
    [XmlRoot("urlset",Namespace="http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class Urlset
    {
        [XmlElement("url")]
        public List<Url> urlList = new List<Url>();
    }
    [Serializable()]
    public class Url
    {
        [XmlElement("loc")]
        public string Loc { get; set; }

        [XmlElement("lastmod")]
        public string Lastmod { get; set; }

        [XmlElement("news:news")]
        public List<News> News { get; set; }

        [XmlElement("image:image")]
        public List<Image> image { get; set; }

    }
    public class News
    {
        [XmlElement("news:title")]
        public string title { get; set; }
    }
    
    public class Image
    {
        [XmlElement("image:loc")]
        public string imageloc { get; set; }
    }
}