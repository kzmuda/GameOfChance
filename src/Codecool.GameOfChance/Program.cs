using System;
using System.Collections.Generic;

namespace Codecool.GameOfChance
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            HistoricalDataSet ds = new HistoricalDataSet(new ConsoleLogger());
            if (args.Length > 0)
            {
                if (int.TryParse(args[0],out number))
                {
                    if (number == 0)
                    {
                        ds.Load();
                    }
                    else if (number > 0)
                    {
                        for (int i = 0; i < number; i++)
                        {
                            ds.Generate();
                        }
                    }
                }
            }

            //Horse horse = new Horse("Filip");
            List<Horse> data = Horse.Read();

            foreach (var horse in data)
            {
                Console.WriteLine($"{horse.Name} {horse.Speed.ToString()}");
            }
            

            foreach (var element in ds.DataPoints)
            {
                Console.WriteLine(element);
            }
        }
    }
}
