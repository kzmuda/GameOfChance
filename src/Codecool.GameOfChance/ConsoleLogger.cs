using System;

namespace Codecool.GameOfChance
{
    public class ConsoleLogger : ILogger
    {
        public void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("INFO ");
            Console.ResetColor();
            Console.WriteLine($"{DateTime.Now}: {message}");
            ;
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ERROR ");
            Console.ResetColor();
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}
