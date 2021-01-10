using System;
using System.Collections.Generic;

namespace Codecool.GameOfChance
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            //Horse horse = new Horse("Filip");
            List<Horse> data = Horse.Read();

            foreach (var horse in data)
            {
                Console.WriteLine($"{horse.Name} {horse.Speed.ToString()}");
            }
        }
    }
}
