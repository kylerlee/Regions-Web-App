﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryApp.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string[] TopLevelDomain { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string[] CallingCodes { get; set; }
        public string Capital { get; set; }
        public string[] AltSpellings { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public int Population { get; set; }
        public float[] LatLng { get; set; }
        public string Demonym { get; set; }
        public float Area { get; set; }
        public float Gini { get; set; }
        public string[] Timezones { get; set; }
        public string[] Borders { get; set; }
        public string NativeName { get; set; }
        public string NumericCode { get; set; }
        public Currency[] Currencies { get; set; }
        public Language[] Languages { get; set; }
        public Translations Translations { get; set; }
        public string Flag { get; set; }
        public Regionalbloc[] RegionalBlocs { get; set; }
        public string Cioc { get; set; }
    }

}