﻿using System;
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
    }
}
