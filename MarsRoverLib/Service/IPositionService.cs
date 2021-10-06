using MarsRoverLib.Enums;
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
        string Start(string maxPoints,string moveCommands);
    }
}
