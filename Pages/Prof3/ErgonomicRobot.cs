using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfWorld.Pages.Prof3
{
    public class ErgonomicRobot : RobotDecorator
    {
        public ErgonomicRobot(Robot robot) : base(robot) { }
        public override string GetDescription()
        {
            return robot.GetDescription() + " эргономичный";
        }
    }
}
