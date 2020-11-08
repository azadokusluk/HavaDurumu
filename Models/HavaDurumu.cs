using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HavaDurumuUygulaması.Models
{
    public class HavaDurumu
    {
        public string success { get; set; }
        public string city { get; set; }
        public result[] result { get; set; }
    }

    public class result
    {
        public string Date { get; set; }
        public string Day { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Degree { get; set; }
        public string Min { get; set; }
        public string Max { get; set; }
        public string Night { get; set; }
        public string Humidity { get; set; }
    }
}