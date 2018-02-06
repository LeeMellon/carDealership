using System;
using System.Collections.Generic;


namespace CarDealership.Models
{
    public class Car
    {
        private string _makeModel;
        private string _description;
        private int _price;
        private int _miles;
        private static List<Car> _instances = new List<Car> {};


        public Car (string makeModel, string description, int price, int miles)
        {
            _makeModel = makeModel;
            _description = description;
            _price = price;
            _miles = miles;
        }

        public bool WorthBuying(int maxPrice, int maxMiles)
        {
          return (GetPrice() < (maxPrice + 100) && GetMiles() < (maxMiles + 500));
        }

        public static List<Car> GetAll()
        {
            return _instances;
        }

        public void SetModel(string newModel)
        {
            _makeModel = newModel;
        }

        public string GetModel()
        {
            return _makeModel;
        }

        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetPrice(int newPrice)
        {
            _price = newPrice;
        }

        public int GetPrice()
        {
            return _price;
        }

        public void SetMiles(int newMiles)
        {
            _miles = newMiles;
        }

        public int GetMiles()
        {
            return _miles;
        }
    }
    // public class Program
    // {
      // public void Main()
      // {
      // }
      //   foreach(Car automobile in Cars)
      //   {
      //     Console.WriteLine(automobile.GetModel() + ", $" + automobile.GetPrice() + ", Desc: " + automobile.GetDescription());
      //     // Console.WriteLine(automobile.GetPrice());
      //   }
      //
      //   Console.WriteLine("Enter maximum price: ");
      //   string stringMaxPrice = Console.ReadLine();
      //   int maxPrice = int.Parse(stringMaxPrice);
      //   Console.WriteLine("Enter maximum miles: ");
      //   string stringMaxMiles = Console.ReadLine();
      //   int maxMiles = int.Parse(stringMaxMiles);
      //
      //   List<Car> CarsMatchingSearch = new List<Car>();
      //
      //   foreach (Car automobile in Cars)
      //   {
      //     if (automobile.WorthBuying(maxPrice, maxMiles))
      //     {
      //       CarsMatchingSearch.Add(automobile);
      //     }
      //
      //   }
      //
      //   if (CarsMatchingSearch.Count == 0)
      //   {
      //     Console.WriteLine("Sorry, there are no cars matching your search. Try again.");
      //   }
      //   else
      //   {
      //     foreach(Car automobile in CarsMatchingSearch)
      //     {
      //       Console.WriteLine(automobile.GetModel());
      //     }
      //   }
      // }
    // }
}
