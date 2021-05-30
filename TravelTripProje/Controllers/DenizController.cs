using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DenizController : Controller
    {
        // GET: Deniz
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.DenizTatils.ToList();
            return View(degerler);
        }
    }
}