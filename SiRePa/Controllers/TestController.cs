﻿using SiRePa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiRePa.Controllers
{
    public class TestController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return Content("Hai Cantik!");
        }

        public ActionResult Json()
        {
            return Json(new { data = "ini json" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PassToView()
        {
            var model = new TestModel
            {
                ID = 1,
                Name = "toni"
            };

            return View(model);
        }

        public ActionResult PassToController()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PassToController(FormCollection form)
        {
            var name = form.GetValue("name").AttemptedValue;
            return RedirectToAction("PassToControllerResult", new { param = name });
        }

        public ActionResult PassToControllerResult(string param)
        {
            var model = new TestModel
            {
                ID = 2,
                Name = param
            };

            return View(model);
        }

        public ActionResult Layout()
        {
            return View();
        }

    }
}
