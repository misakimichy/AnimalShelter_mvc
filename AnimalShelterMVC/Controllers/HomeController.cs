using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AnimalShelter.Models;

namespace  AnimalShelter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}