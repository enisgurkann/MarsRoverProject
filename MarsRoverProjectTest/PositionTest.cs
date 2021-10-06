using MarsRoverLib;
using MarsRoverLib.Enums;
using System;
using Xunit;

namespace MarsRoverProjectTest
{
    //hb dökümanýndaki verilere göre
    public class PositionTest
    {
        [Fact]
        public void Test_Scenario_1()
        {
            var service = new PositionService(1, 2, Directions.North);
            string position = service.Start("5 5", "LMLMLMLMM");

            Assert.Equal("1 3 N", position);
        }

        [Fact]
        public void Test_Scenario_2()
        {
            var service = new PositionService(3, 3, Directions.East);
            string position = service.Start("5 5", "MMRMMRMRRM");
            Assert.Equal("5 1 E", position);
        }
    }
}
