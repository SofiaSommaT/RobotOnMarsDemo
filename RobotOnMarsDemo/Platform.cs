using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOnMarsDemo
{
    public class Platform
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Platform() { }
        public Platform(int x, int y) { X = x; Y = y; }
    }
}
