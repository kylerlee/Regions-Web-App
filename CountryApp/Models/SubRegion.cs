using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryApp.Models
{
    public class SubRegion
    {
        public string Name { get; set; }
        public List<Country> Countries { get; set; }
    }
}