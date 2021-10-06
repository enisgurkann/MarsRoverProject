using MarsRoverLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverLib.Helper
{
    public static class DirectionHelper
    {
        public static Directions? RotateRight(Directions Direction)
        {
            if (Direction == Directions.North)
                return Directions.East;
            else if (Direction == Directions.South)
                return Directions.West;
            else if (Direction == Directions.South)
                return Directions.East;
            else if (Direction == Directions.West)
                return Directions.North;
            else
                return null;
        }
        public static Directions? RotateLeft(Directions Direction)
        {
            if (Direction == Directions.North)
                return Directions.West;
            else if (Direction == Directions.South)
                return Directions.East;
            else if (Direction == Directions.East)
                return Directions.North;
            else if (Direction == Directions.West)
                return Directions.South;
            else
                return null;
        }

    }
}
