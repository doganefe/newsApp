using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HaberSite.Models
{
    public class haber
    {
        public string status { get; set; }
        public List<Item> articles { get; set; }
        public int totalResults { get; set; }

    }
    public class Item
    {
        public string title { get; set; }
        public string content { get; set; }
    }
}