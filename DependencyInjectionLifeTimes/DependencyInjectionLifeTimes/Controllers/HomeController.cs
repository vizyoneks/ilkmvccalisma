using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjectionLifeTimes.Models;
using DependencyInjectionLifeTimes.Services;

namespace DependencyInjectionLifeTimes.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUtilitySingletonService _utilitySingletonService;
        private readonly IUtilityScopedService _utilityScopedService;
        private readonly IUtilityScopedService _utilityScopedService2;


        private readonly IUtilityTransientService _utilityTransientService;
        private readonly IUtilityTransientService _utilityTransientService2;

        public HomeController(IUtilitySingletonService utilitySingletonService, IUtilityScopedService utilityScopedService, IUtilityTransientService utilityTransientService, IUtilityTransientService utilityTransientService2, IUtilityScopedService utilityScopedService2)
        {
            _utilitySingletonService = utilitySingletonService;
            _utilityScopedService = utilityScopedService;
            _utilityTransientService = utilityTransientService;

            _utilityTransientService2 = utilityTransientService2;
            _utilityScopedService2 = utilityScopedService2;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";


            ViewBag.Transient = _utilityTransientService.ReturnValue();
            ViewBag.Transient2 = _utilityTransientService2.ReturnValue();

            ViewBag.Scoped = _utilityScopedService.ReturnValue();
            ViewBag.Scoped2 = _utilityScopedService2.ReturnValue();

            ViewBag.Singleton = _utilitySingletonService.ReturnValue();
            ViewBag.Singleton2 = _utilitySingletonService.ReturnValue();


            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
