using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverLib.Service
{
    public interface IPositionService
    {
        void Start(string maxPoints, string step);
    }
}
