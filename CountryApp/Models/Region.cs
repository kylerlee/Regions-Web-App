using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryApp.Models
{
    public class Region
    {
        public string Name { get; set; }
        public List<SubRegion> SubRegions { get; set; }
    }
}