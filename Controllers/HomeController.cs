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
          Car porsche = new Car ("2014 Porsche 911", "Favorite of pretentious car owners like Kelly Clarkson.", 114991, 7864);
          Car ford = new Car("2011 Ford F450", "The car that Katy Perry named her first child after.", 55995, 14241);
          Car lexus = new Car("2013 Lexus RX 350", "Preferred vehicle of vocal star Carly Rae Jepsen.", 44700, 20000);
          Car mercedes = new Car("Mercedes Benz CLS550", "Loved by both P!nk and Shakira. That's right. BOTH OF THEM.", 39900, 37979);
          List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
          return View();
        }
    }
}
