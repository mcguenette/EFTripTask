using IPBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFTripTask.Controllers
{
    public class TempController : Controller
    {
        // GET: Temp
        public ActionResult Index()
        {
           TripService ts = new TripService();
            var trips = ts.GetTrips();//added DAL to project -but not right way
            return View(trips);
        }
    }
}