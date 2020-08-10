using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        //Member Variables
        public List<Robot> robots;
        //Constructor

        //Member Mehtods
        public Fleet()
        {
            Robot robot1 = new Robot("Bender");
            Robot robot2 = new Robot("R2D2");
            Robot robot3 = new Robot("C3PO");
            robots = new List<Robot>();
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
        }
    }
}
