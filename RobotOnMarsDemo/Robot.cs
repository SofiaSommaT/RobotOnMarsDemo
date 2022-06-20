using RobotOnMarsDemo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOnMarsDemo
{
    

    public class Robot
    {
        public Position Position { get; set; } = new Position();
        public CardinalPoints Facing { get; set; } = CardinalPoints.North;

    }

    public class Position
    {
        public int X { get; set; } = 1;

        public int Y { get; set; } = 1;
    }

    

   
}
