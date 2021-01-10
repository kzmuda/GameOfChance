using System;

namespace Codecool.GameOfChance
{
    public class ConsoleLogger : ILogger
    {
        public void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"INFO");
            Console.ResetColor();
            Console.WriteLine($"{DateTime.Now.ToString()}: {message}");
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"ERROR");
            Console.ResetColor();
            Console.WriteLine($"{DateTime.Now.ToString()}: {message}");
        }
    }
}
