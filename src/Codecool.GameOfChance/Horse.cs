using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;

namespace Codecool.GameOfChance
{
    public class Horse
    {
        public string Name { get; }
        public int Speed { get; }

        public static List<Horse> Read()
        {
            List<Horse> data = new List<Horse>();

            if (!File.Exists("horses.csv"))
            {
                throw new FileNotFoundException("File not found.");
            }
            
            using (var file = File.OpenText("horses.csv"))
            {
                file.ReadLine();
                
                while (!file.EndOfStream)
                {
                    var lineSplitted = file.ReadLine().Split(",");
                    
                    data.Add(new Horse(lineSplitted[0], Convert.ToInt32(lineSplitted[1])));
                }
            }

            return data;
        }
        
        public Horse(string name, int speed)
        {
            Name = name.ToUpper();
            Speed = speed;
        }

        public Horse(string name) : this(name, 50)
        {
        }
    }
}
