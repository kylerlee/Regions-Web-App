using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryApp.Models;

namespace CountryApp.Services
{
    public class RegionService
    {
        private CountryService countryService = new CountryService();

        public List<Region> GetRegions()
        {
            List<Country> countries = countryService.GetCountries();

            if (countries == null)
                return null;
            
            List<Region> regions = new List<Region>();

            var regionList = countries.Select(x => x.Region).Distinct().ToList();
            regionList.Sort();
            
            foreach(var region in regionList)
            {
                var subRegions = countries.Where(c => c.Region == region).Select(r => r.SubRegion).Distinct().ToList();
                subRegions.Sort();

                var subRegionList = new List<SubRegion>();
                foreach(var subRegion in subRegions)
                {
                    var subRegionCountries = countries.Where(x => x.SubRegion == subRegion && x.Region == region).ToList();
                    subRegionCountries.Sort((x, y) => x.Name.CompareTo(y.Name));

                    var subRegionInfo = new SubRegion()
                    {
                        Name = subRegion,
                        Countries = subRegionCountries
                    };
                    subRegionList.Add(subRegionInfo);
                }

                var regionInfo = new Region()
                {
                    Name = region,
                    SubRegions = subRegionList
                };
                regions.Add(regionInfo);
            }

            return regions;
        }
    }

}