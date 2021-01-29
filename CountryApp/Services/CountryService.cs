using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using CountryApp.Models;
using Newtonsoft.Json;

namespace CountryApp.Services
{
    public class CountryService
    {
        private string countryApiHost = ConfigurationManager.AppSettings["CountryApiHost"];

        public List<Country> GetCountries()
        {
            List<Country> countries = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(countryApiHost);
                var responseTask = client.GetAsync("all");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    // Replacing empty string to Nil for a clear data representation.
                    string updatedString = readTask.Result.Replace(":\"\"", ":\"Nil\"");

                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };

                    countries = JsonConvert.DeserializeObject<List<Country>>(updatedString, settings);
                }
                else
                {
                    throw new HttpRequestException("Country API server error. Please contact administrator.");
                }
            }
            return countries;
        }
    }
}