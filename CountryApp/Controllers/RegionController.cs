using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CountryApp.Models;
using CountryApp.Services;

namespace CountryApp.Controllers
{
    public class RegionController : Controller
    {
        RegionService regionService = new RegionService();

        [HttpGet]
        public ActionResult List()
        {
            try
            {
                var regions = regionService.GetRegions();
                if (regions == null)
                    return View("Error");
                else
                    return View(regions);
            }
            catch
            {
                return View("Error");
            }
        }
    }
}