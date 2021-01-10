using System;
namespace Codecool.GameOfChance
{
    public class Horse
    {
        public string Name { get; }
        public int Speed { get; }

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
