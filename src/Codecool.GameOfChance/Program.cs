using System;

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

            Horse horse = new Horse("Filip");
           
        }
    }
}
