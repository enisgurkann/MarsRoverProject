using MarsRoverLib.Enums;
using MarsRoverLib.Helper;
using MarsRoverLib.Models;
using MarsRoverLib.Service;
using System;

namespace MarsRoverLib
{
    public class PositionService : IPositionService
    {
       

        public PositionService()
        {
        }

        public PositionReturnModel Start(string maxPoints, string steps)
        {
            var model = new PositionReturnModel();
            model.Status = true;
            foreach (var step in steps)
            {

                if (step == 'M')
                {
                }
                else if (step == 'L')
                {

                }
                else if (step == 'R')
                {

                }
                else
                    model = new PositionReturnModel() { Message = $"{step} karakteri geçersiz",Status = false } ;


            }

            return model;
        }
    }
}
