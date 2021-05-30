using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class MuzeController : Controller
    {
        // GET: OtelRehberi
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Muzes.ToList();
            return View(degerler);
        }
    }
}