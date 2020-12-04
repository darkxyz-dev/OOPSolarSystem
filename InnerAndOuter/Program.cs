using System;
using System.Collections.Generic;
using System.IO;

namespace InnerAndOuter
{

    class Program
    {
        public class Item
        {
            string planet;
            int mass;

            public Item(string _name, int _price)
            {
                planet = _name;
                mass = _price;

            }

            public string Name { get { return planet; } }
            public int Price { get { return mass; } }
        }
        static void Main(string[] args)
        {
            InnerPlanetList();
            OuterPlanetList();
        }

        public static void InnerPlanetList()
        {
            List<string> planetList = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("enter planet: ");
                string item = Console.ReadLine();
                Console.WriteLine("enter mass: ");
                string price = Console.ReadLine();

                string line = $"{item}${price}";
                planetList.Add(line);
            }
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"innerPlanets.txt";
            File.WriteAllLines(Path.Combine(filePath, fileName), planetList);

            


        }

        public static void OuterPlanetList()
        {
            List<string> planetList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter planet: ");
                string item = Console.ReadLine();
                Console.WriteLine("enter mass: ");
                string price = Console.ReadLine();

                string line = $"{item}${price}";
                planetList.Add(line);
            }
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"OuterPlanets.txt";
            File.WriteAllLines(Path.Combine(filePath, fileName), planetList);
        }


    }

}
