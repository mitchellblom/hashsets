using System;
using System.Collections.Generic;

namespace hashsets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Showroom 
            HashSet<string> Showroom = new HashSet<string>() {"Mustang", "Camero", "Charger", "BRZ"};

            Console.WriteLine(Showroom.Count);

            Showroom.Add("Mustang");

            foreach (string car in Showroom) {
                Console.WriteLine(car);
            }

            // UsedLot
            HashSet<string> UsedLot = new HashSet<string>() {"Spider", "350Z"};

            Showroom.UnionWith(UsedLot);

            Console.WriteLine("Union of both sets: ");
            foreach (string car in Showroom) {
                Console.WriteLine(car);
            }

            Showroom.Remove("BRZ");

            Console.WriteLine("BRZ removed: ");
            foreach (string car in Showroom) {
                Console.WriteLine(car);
            }

            // Junkyard
            HashSet<string> Junkyard = new HashSet<string>() {"Accord", "Explorer", "Element", "Mustang", "Spider"};

            HashSet<string> CommonCars = new HashSet<string>() {};

            Showroom.IntersectWith(Junkyard);

            Console.WriteLine("Intersecting models: ");
            
            foreach (string car in Showroom) {
                Console.WriteLine(car);
            }

            Showroom.UnionWith(Junkyard);

            Showroom.Remove("Element");

        }
    }
}
