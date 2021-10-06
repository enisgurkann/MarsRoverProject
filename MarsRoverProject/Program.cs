using System;
using System.Linq;

namespace MarsRoverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Mars Rover Project!");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Plato Max Point : ");
            var maxPoint = Console.ReadLine().Trim().Split(' ').ToList();

            Console.Write("Start Position : ");
            var startPosition = Console.ReadLine().Trim().Split().ToList();



            Console.ReadLine();

        }
    }
}
