using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalShelterContext _db;

        public AnimalController(AnimalShelterContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            // Using LINQ to order the animal list by ascending the name alphabetically
            List<Animal> model = _db.Animals.ToList();
            IEnumerable<Animal> query = model.OrderBy(animal => animal.Name);
            return View(query.ToList());
        }

        public ActionResult IndexBySpecies()
        {
            List<Animal> model = _db.Animals.ToList();
            IEnumerable<Animal> query =
                from animal in model
                orderby animal.Species ascending
                select animal;
            return View("Index", query.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            Animal thisAnimal = _db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            return View(thisAnimal);
        }

        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}