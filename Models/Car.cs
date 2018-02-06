using System.Collections.Generic;
using System;


namespace CarDealership.Models
{
    public class Car
    {
        private string _makeModel;
        private string _description;
        private int _price;
        private int _miles;
        private static List<Car> _instances = new List<Car>();

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

        public static List<Car> SearchResults(int intMaxPrice, int intMaxMiles)
        {
            List<Car> filteredCars = new List<Car>();
            for(int index = 0; index < _instances.Count; index++)
            {
              if (_instances[index].WorthBuying(intMaxPrice, intMaxMiles))
              {
                filteredCars.Add(_instances[index]);
              }
            }
            return filteredCars;
        }

        public static List<Car> GetAll()
        {

            return _instances;
        }

        public void CarSave()
        {
            _instances.Add(this);
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
}
