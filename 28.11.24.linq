<Query Kind="Statements" />

// Примеры данных
var countries = new List<Country>
{
    new Country { CountryId = 1, Name = "Россия", Population = 146599183, Continent = "Европа", Area = 17098242 },
    new Country { CountryId = 2, Name = "США", Population = 331002651, Continent = "Северная Америка", Area = 9372610 },
    new Country { CountryId = 3, Name = "Китай", Population = 1439323776, Continent = "Азия", Area = 9596961 },
    new Country { CountryId = 4, Name = "Франция", Population = 65273511, Continent = "Европа", Area = 551695 }
};

var capitals = new List<Capital>
{
    new Capital { CapitalId = 1, Name = "Москва", Population = 11920000, CountryId = 1 },
    new Capital { CapitalId = 2, Name = "Вашингтон", Population = 705749, CountryId = 2 },
    new Capital { CapitalId = 3, Name = "Пекин", Population = 21540000, CountryId = 3 },
    new Capital { CapitalId = 4, Name = "Париж", Population = 2148000, CountryId = 4 }
};

var cities = new List<City>
{
    new City { CityId = 1, Name = "Санкт-Петербург", Population = 5384000, CountryId = 1 },
    new City { CityId = 2, Name = "Нью-Йорк", Population = 8419600, CountryId = 2 },
    new City { CityId = 3, Name = "Шанхай", Population = 24183300, CountryId = 3 },
    new City { CityId = 4, Name = "Марсель", Population = 861635, CountryId = 4 }
};

var allCountries = countries.ToList();
allCountries.ForEach(c => 
    Console.WriteLine($"Страна: {c.Name}, Население: {c.Population}, Континент: {c.Continent}, Площадь: {c.Area}"));
	
var capitalNames = capitals.Select(c => c.Name).ToList();
capitalNames.ForEach(name => Console.WriteLine(name));

int specificCountryId = 1; // ID России
var majorCitiesInCountry = cities
    .Where(city => city.CountryId == specificCountryId)
    .Select(city => city.Name)
    .ToList();

majorCitiesInCountry.ForEach(name => Console.WriteLine(name));

var capitalsWithLargePopulation = capitals
    .Where(c => c.Population > 5000000)
    .Select(c => c.Name)
    .ToList();

capitalsWithLargePopulation.ForEach(name => Console.WriteLine(name));

var europeanCountries = countries
    .Where(c => c.Continent == "Европа")
    .Select(c => c.Name)
    .ToList();

europeanCountries.ForEach(name => Console.WriteLine(name));

double specificArea = 10000000; // Площадь
var largeAreaCountries = countries
    .Where(c => c.Area > specificArea)
    .Select(c => c.Name)
    .ToList();

largeAreaCountries.ForEach(name => Console.WriteLine(name));