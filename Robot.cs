using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        //Member Variables
        public string name;
        public int health;
        public int powerLevel;
        public string weaponType;
        //Constructor
        public Robot(string name)
        {
            health = 100;
            weaponType = "sword";
            powerLevel = 100;
            this.name = name;
        }
        //Member Mehtods

    }
}
