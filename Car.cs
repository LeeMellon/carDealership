using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private string _description;
  private int _price;
  private int _miles;

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




public class Program
{
  public static void Main()
  {
    Car porsche = new Car ("2014 Porsche 911", "Favorite of pretentious car owners like Kelly Clarkson.", 114991, 7864);
    Car ford = new Car("2011 Ford F450", "The car that Katy Perry named her first child after.", 55995, 14241);
    Car lexus = new Car("2013 Lexus RX 350", "Preferred vehicle of vocal star Carly Rae Jepsen.", 44700, 20000);
    Car mercedes = new Car("Mercedes Benz CLS550", "Loved by both P!nk and Shakira. That's right. BOTH OF THEM.", 39900, 37979);
    porsche.SetPrice(100);
    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetModel() + ", $" + automobile.GetPrice() + ", Desc: " + automobile.GetDescription());
      // Console.WriteLine(automobile.GetPrice());
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetModel());
    }
  }
}
