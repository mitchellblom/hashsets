using System;
using System.Collections.Generic;

namespace hashsets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>() {"Mustang", "Camero", "Charger", "BRZ"};

            Console.WriteLine(Showroom.Count);

            Showroom.Add("Mustang");

            foreach (string car in Showroom) {
                Console.WriteLine(car);
            }

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

        }
    }
}
