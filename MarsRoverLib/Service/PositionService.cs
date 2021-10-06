using MarsRoverLib.Enums;
using MarsRoverLib.Helper;
using MarsRoverLib.Models;
using MarsRoverLib.Service;
using System;

namespace MarsRoverLib
{
    public class PositionService : IPositionService
    {
       
        public PositionReturnModel Start(string maxPoints, string steps)
        {
            int X = 0, Y = 0;
            var currentDirection = Directions.North;

            var model = new PositionReturnModel();
            model.Status = true;

            
            foreach (var step in steps)
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
                   return new PositionReturnModel() { Message = $"{step} karakteri geçersiz",Status = false } ;
            }




            return model;
        }
    }
}
