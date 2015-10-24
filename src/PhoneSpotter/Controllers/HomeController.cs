using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PhoneSpotter.Models;
using Microsoft.Framework.OptionsModel;

namespace PhoneSpotter.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationOptions Options { get; set; }

        public HomeController(IOptions<ApplicationOptions> options)
        {
            Options = options.Value;
        }

        private void LoadViewData()
        {
            ViewData["SiteTitle"] = Options.SiteTitle ?? "Site Title Missing, Shoot Developer";
        }

        public IActionResult Index()
        {
            LoadViewData();
            return View();
        }

        public IActionResult About()
        {
            LoadViewData();
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            LoadViewData();
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            LoadViewData();
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
