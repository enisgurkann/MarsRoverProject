using MarsRoverLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverLib.Service
{
    public interface IPositionService
    {
        PositionReturnModel Start(string maxPoints, string steps);
    }
}
