using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcExamples.Areas.Uretim.Controllers
{
    [Area("Uretim")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}