using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chapt1_3.Models;
using Chapt1_3.Time;

namespace Chapt1_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClock _clock;

        // public HomeController(IClock clock)
        // {
        //     _clock = clock;
        // }
        public HomeController(ILogger<HomeController> logger, IClock clock)
        {
            _clock = clock;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = $"It is {_clock.GetTime().ToString("T")}";
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
