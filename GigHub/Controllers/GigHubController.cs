﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigHubController : Controller
    {
        // GET: GigHub
        public ActionResult Index()
        {
            string gig;
            return View();
        }
    }
}