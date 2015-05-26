using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiRePa.Controllers
{
    public class NoviewController : Controller
    {
        // GET: Noview
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Exist()
        {
            return View();
        }
    }
}