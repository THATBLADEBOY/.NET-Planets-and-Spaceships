using System;
using System.Collections.Generic;

namespace planets_and_spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> secondPlanetList = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(secondPlanetList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
              foreach(string planet in rockyPlanets) {
                Console.Write(planet);
            }

            Console.WriteLine();

            planetList.Remove("Pluto");
            foreach(string planet in planetList) {
                Console.Write(planet);
            }

            Console.WriteLine();
        }
    }
}
