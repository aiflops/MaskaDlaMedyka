﻿using System.Web.Mvc;

namespace MDMProject.Controllers
{
    public class MapController : ControllerBase
    {
        // GET: Map
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}