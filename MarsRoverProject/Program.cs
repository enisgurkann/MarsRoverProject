using MarsRoverLib;
using MarsRoverLib.Enums;
using MarsRoverLib.Service;
using System;
using System.Linq;

namespace MarsRoverProject
{
    class Program
    {
   
        public Program()
        {
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Mars Rover Project!");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Plato Max Point : ");
            string maxPoint = Console.ReadLine();

            Console.Write("Start Position : ");
            var startPosition = Console.ReadLine().Trim().Split(' ');

            if (startPosition.Count() == 3)
            {
                var X = Convert.ToInt32(startPosition[0]);
                var Y = Convert.ToInt32(startPosition[1]);
                var Direction = Enum.Parse<Directions>(startPosition[2]);

                var _service = new PositionService(X, Y, Direction);


                Console.Write("Move Commands : ");
                string moveCommands = Console.ReadLine();

                var model = _service.Start(maxPoint, moveCommands);

                if (model.Status)
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                else
                    Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine(model.Message);


            }





            Console.ReadLine();

        }
    }
}
