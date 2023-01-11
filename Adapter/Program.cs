using Adapter._2.Target;
using Adapter._3.Adapter;

Console.Title = "Adapter";

// adapter example (same code for object & class adapter)
ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
Console.ReadKey();