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

    }
}
