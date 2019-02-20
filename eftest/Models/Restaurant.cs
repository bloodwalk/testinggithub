using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eftest.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        public string straat { get; set; }
        public string code { get; set; }
        public plaatsen plaatsnaam { get; set; }
    }

    public enum plaatsen
    {
        Amsterdam,
        Rotterdam,
        Haarlem

    };
}
