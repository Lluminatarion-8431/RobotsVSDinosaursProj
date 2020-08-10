using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        //Member Variables
        public int attackPower;
        public string type;
        //Constructor
        public Weapon(string type)
        {
            attackPower = 35;
            this.type = type;
        }
        //Member Mehtods
    }
}
