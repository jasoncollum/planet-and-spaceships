using System;
using System.Collections.Generic;

namespace planet_and_spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // Add Jupiter and Saturn to the end of the list
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // Create new list of last 2 planets and add to planetList
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastTwoPlanets);

            // Use insert to add Earth and Venus in the correct order
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            // Add Pluto to the end of the list
            planetList.Add("Pluto");

            // Create a new list of the rocky planets
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            // Remove Pluto from the list
            planetList.Remove("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));
        }
    }
}
