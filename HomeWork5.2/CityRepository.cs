using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5._2
{
    public static class CityRepository
    {
        public static IEnumerable<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country
                {
                    Name = "Беларусь",
                    Lang = "BY",
                    District = new District
                    {
                        Name = "Минская область",
                        Count = 32,
                        City = new City
                        {
                            Name = "Несвиж",
                            ZipCode = "31231244",
                            Neighborhood = new Neighborhood
                            {
                                StreetName = "ул. Улица",
                                HouseNumber = "10",
                            }
                        }
                    }
                },
                new Country
                {
                    Name = "Беларусь",
                    Lang = "BY",
                    District = new District
                    {
                        Name = "Минская область",
                        Count = 32,
                        City = new City
                        {
                            Name = "Слуцк",
                            ZipCode = "534535",
                            Neighborhood = new Neighborhood
                            {
                                StreetName = "ул. Главная",
                                HouseNumber = "56",
                            }
                        }
                    }
                },
                new Country
                {
                    Name = "Польша",
                    Lang = "PL",
                    District = new District
                    {
                        Name = "Варшавская обл.",
                        Count = 32,
                        City = new City
                        {
                            Name = "Варшава",
                            ZipCode = "4456656445",
                            Neighborhood = new Neighborhood
                            {
                                StreetName = "ул. Какая-то еще улица",
                                HouseNumber = "555",
                            }
                        }
                    }
                }
            };
        }
    }
}
