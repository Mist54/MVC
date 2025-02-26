using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCanva.Controllers
{
    public class CanvaController : Controller
    {
        // GET: Canva
        public ActionResult Index()
        {
            return View();
        }
    }
}