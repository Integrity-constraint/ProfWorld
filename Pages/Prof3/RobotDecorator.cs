using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfWorld.Pages.Prof3
{
    public abstract class RobotDecorator : Robot
    {
        protected Robot robot;
        public RobotDecorator(Robot robot)
        {
            this.robot = robot;
        }
    }
}
