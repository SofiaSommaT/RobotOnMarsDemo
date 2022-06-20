using RobotOnMarsDemo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOnMarsDemo
{
    public interface IMakeMovement
    {
        public void Walk(Platform platform, Robot robot, string path);

    }
}
