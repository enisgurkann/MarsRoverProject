using MarsRoverLib.Enums;
using MarsRoverLib.Helper;
using MarsRoverLib.Models;
using MarsRoverLib.Service;
using System;
using System.Linq;

namespace MarsRoverLib
{
    public class PositionService : IPositionService
    {
        private int X, Y;
        private Directions currentDirection;
        public PositionService(int startX,int startY,Directions startDirection)
        {
            X = startX;
            Y = startY;
            currentDirection = startDirection;
        }

        public string Start(string maxPoints, string moveCommands)
        {

            foreach (var step in moveCommands)
            {

                if (step == 'M')
                {
                    var moveDirection = DirectionHelper.MoveDirection(X, Y, currentDirection);
                    X = moveDirection.X;
                    Y = moveDirection.Y;
                }
                else if (step == 'L')
                    currentDirection = DirectionHelper.RotateLeft(currentDirection);
                else if (step == 'R')
                    currentDirection = DirectionHelper.RotateRight(currentDirection);
                else
                    throw new Exception($"{step} karakteri geçersiz");
            }


            return $"{X} {Y} {currentDirection.ToString()}";
        }
    }
}
