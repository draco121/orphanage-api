using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace orphanage_api.Models
{
    public class Orphanage
    {
       public int id { get; set; }

        public string name { get; set; }

        public string registrationnum { get; set; }

        public string addressl1 { get; set; }

        public string addressl2 { get; set; }

        public string landmark { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string pin { get; set; }

        public string phone { get; set; }

        public string country { get; set; }

        public string password { get; set; }

    }


}