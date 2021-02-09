using System;
using System.Linq;

namespace HomeWork5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = CityRepository.GetCountries();
            var streets = countries.Select(county => county.District.City.Neighborhood.StreetName);

            foreach (var street in streets)
            {
                Console.WriteLine(street);
            }
        }
    }
}
