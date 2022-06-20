using RobotOnMarsDemo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOnMarsDemo
{
    public class MakeMovement : IMakeMovement
    {
       
        public void Walk(Platform platform, Robot robot, string path)
        {
            foreach(var step in path)
            {
                var command = (Commands)Enum.ToObject(typeof(Commands), step);
                if (command == Commands.Front)
                    StepUp(robot, platform);
                else TurnAround(robot, command);
            }
        }

        private void StepUp(Robot robot, Platform platform)
        {
            switch (robot.Facing)
            {
                case CardinalPoints.North:
                    robot.Position.Y = robot.Position.Y + 1 <= platform.Y ? robot.Position.Y += 1 : robot.Position.Y;
                    break;
                case CardinalPoints.South:
                    robot.Position.Y = robot.Position.Y-1 > 0 ? robot.Position.Y -= 1 : robot.Position.Y;
                    break;
                case CardinalPoints.East:
                    robot.Position.X = robot.Position.X + 1 <= platform.X ? robot.Position.X += 1 : robot.Position.X;
                    break;
                case CardinalPoints.West:
                    robot.Position.X = robot.Position.X-1 > 0 ? robot.Position.X -= 1 : robot.Position.X;
                    break;

            }
        }

        private void TurnAround(Robot robot, Commands command)
        {
            switch(robot.Facing)
            {
                case CardinalPoints.North:
                    if (command == Commands.Left)
                        robot.Facing = CardinalPoints.West;
                    if (command == Commands.Right)
                        robot.Facing = CardinalPoints.East;
                    break;
                case CardinalPoints.South:
                    if (command == Commands.Left)
                        robot.Facing = CardinalPoints.East;
                    if (command == Commands.Right)
                        robot.Facing = CardinalPoints.West;
                    break ;
                case CardinalPoints.East:
                    if (command == Commands.Left)
                        robot.Facing = CardinalPoints.North;
                    if (command == Commands.Right)
                        robot.Facing = CardinalPoints.South;
                    break;
                case CardinalPoints.West:
                    if (command == Commands.Left)
                        robot.Facing = CardinalPoints.South;
                    if (command == Commands.Right)
                        robot.Facing = CardinalPoints.North;
                    break;

            }
        }
    }
}
