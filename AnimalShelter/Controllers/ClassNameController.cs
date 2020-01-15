using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
    public class ClassNameController : Controller
    {
        [HttpGet("/className")]
        public ActionResult Index()
        {
            return View();
        }
    }
}