using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using PhoneSpotter.Models;
using PhoneSpotter.ViewModels.PhoneSpottings;
using Microsoft.AspNet.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneSpotter.Controllers
{
    public class PhoneSpottingController : Controller
    {
        private PhoneSpottingDbContext _spotContext;

        public PhoneSpottingController(PhoneSpottingDbContext context)
        {
            _spotContext = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new PhoneSpottingsViewModel { PhoneSpottings = _spotContext.Spottings.ToList() });
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Create(PhoneSpotting newSpotting)
        {
            if(ModelState.IsValid)
            {
                _spotContext.Spottings.Add(newSpotting);
                _spotContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(newSpotting);
        }
    }
}
