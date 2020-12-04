using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OOPSolarSystem
{
    class Program
    {

        
        public class Planet
        {
            string name;
            int price;

            public Planet(string _name, int _price)
            {
                name = _name;
                price = _price;

            }
            public string Name { get { return name; } }
            public int Price { get { return price; } }
            static void Main(string[] args)
            {
                ReadFromPlanetList();
            }
            public static void ReadFromPlanetList()
            {
                string filePath = @"C:\Users\opilane\samples";
                string fileName = @"planets.txt";

                List<Planet> planetItems = new List<Planet>();

                List<string> linesFromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();

                foreach (string line in linesFromFile)
                {
                    string[] teampArray = line.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);

                    Planet newItem = new Planet(teampArray[0], Int32.Parse(teampArray[1]));
                    planetItems.Add(newItem);



                }

                Console.WriteLine("Your planets:");
                int total = 0;
                foreach (Planet item in planetItems)
                {
                    Console.WriteLine($"Planet: {item.Name}); Price: {item.Price }");
                    total += item.Price;
                }


            }
        }
    }
}