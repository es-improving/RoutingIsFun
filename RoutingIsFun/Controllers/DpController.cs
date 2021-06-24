using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingIsFun.Controllers
{
    public class DpController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("SharedTemplate");
        }
    }
}
