﻿using IPBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFTripTask.Controllers
{
    public class TripController : Controller
    {
        // GET: Trip
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetTrips() 
        { 
            TripService ts = new TripService();
            var trps = ts.GetTrips();
            return Json(trps);
        }
    }
}