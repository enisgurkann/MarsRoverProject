using MarsRoverLib.Enums;
using MarsRoverLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverLib.Helper
{
    public static class DirectionHelper
    {
        public static Directions RotateRight(Directions Direction)
        {
            if (Direction == Directions.North)
                return Directions.East;
            else if (Direction == Directions.South)
                return Directions.West;
            else if (Direction == Directions.South)
                return Directions.East;
            else 
                return Directions.North;
        }
        public static Directions RotateLeft(Directions Direction)
        {
            if (Direction == Directions.North)
                return Directions.West;
            else if (Direction == Directions.South)
                return Directions.East;
            else if (Direction == Directions.East)
                return Directions.North;
            else 
                return Directions.South;
          
        }

        public static DirectionMoveModel MoveDirection(int X,int Y, Directions direction)
        {
            var model = new DirectionMoveModel() { X = X, Y = Y };
            if (direction == Directions.North)
                model.Y += 1;
            else if (direction == Directions.South)
                model.Y -= 1;
            else if (direction == Directions.East)
                model.X += 1;
            else if (direction == Directions.West)
                model.X -= 1;

            return model;
        }

        public static Directions? GetDirection(string Key)
        {
            if (Key == "N")
                return Directions.North;
            else if (Key == "S")
                return Directions.South;
            else if (Key == "E")
                return Directions.East;
            else if (Key == "W")
                return Directions.West;
            else
                return null;
        }
        public static string GetDirectionKey(Directions direction)
        {
            if (direction == Directions.North)
                return "N";
            else if (direction == Directions.South)
                return "S";
            else if (direction == Directions.East)
                return "E";
            else if (direction == Directions.West)
                return "W";
            else
                return null;
        }

    }
}
