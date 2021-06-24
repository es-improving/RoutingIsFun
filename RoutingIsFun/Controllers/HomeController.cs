using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoutingIsFun.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingIsFun.Controllers
{
    public class DateFirstParametersObject
    {
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Category { get; set; }

        public string Title { get; set; }
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DateFirstPost(DateFirstParametersObject parameters)
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("SharedTemplate");
        }

        public IActionResult DateFirstPostTitleOnly()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("SharedTemplate");
        }

        public IActionResult Watch()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("SharedTemplate");
        }

        public IActionResult CatchAll()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("SharedTemplate");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
