using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryApp.Models
{
    public class Regionalbloc
    {
        public string Acronym { get; set; }
        public string Name { get; set; }
        public object[] OtherAcronyms { get; set; }
        public object[] OtherNames { get; set; }
    }

}