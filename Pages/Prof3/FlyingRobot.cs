using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfWorld.Pages.Prof3
{
    public class FlyingRobot : RobotDecorator
    {
        public FlyingRobot(Robot robot) : base(robot) { }

        public override string GetDescription()
        {
            return robot.GetDescription() + " умеет летать";
        }
    }
}
