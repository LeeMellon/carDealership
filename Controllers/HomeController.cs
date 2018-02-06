using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            // List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
            List<Car> allCars = Car.GetAll();
            if (allCars.Count == 0)
              {
                  return View();
              }
              else
              {
                  return View(allCars);
              }
        }

        [Route("/car/list")]
        public ActionResult CarList()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }

        [Route("/car/form")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/car/create")]
        public ActionResult CreateCar()
        {
            string stringPrice =  Request.Form["price"];
            int intPrice = int.Parse(stringPrice);
            string stringMiles =  Request.Form["miles"];
            int intMiles = int.Parse(stringMiles);
            Car newCar = new Car (Request.Form["makeModel"], Request.Form["description"], intPrice, intMiles);
            newCar.Save();
            return View(newCar);
        }
    }
}
