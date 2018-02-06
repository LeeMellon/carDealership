using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Index()
        {
            return View(Car.GetAll());
        }

        [Route("/car/search")]
        public ActionResult Search()
        {
            string stringMaxPrice = Request.Form["maxPrice"];
            int intMaxPrice = int.Parse(stringMaxPrice);
            string stringMaxMiles = Request.Form["maxMiles"];
            int intMaxMiles = int.Parse(stringMaxMiles);

            return View(Car.SearchResults(intMaxPrice, intMaxMiles));
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
            newCar.CarSave();
            return View(newCar);
        }
    }
}
