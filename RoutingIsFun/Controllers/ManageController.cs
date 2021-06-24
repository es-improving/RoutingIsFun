using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingIsFun.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Details(string thingToManage, string thingGuid, string subThing, string subThingId, string routeName)
        {
            ViewBag.Path = Request.Path.ToString();
            ViewBag.RouteValues = Request.RouteValues;
            ViewBag.Query = Request.Query;

            return View("SharedTemplate");
        }
    }
}
