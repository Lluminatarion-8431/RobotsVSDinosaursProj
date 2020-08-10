using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        //Member Variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        //Constructor
        public Dinosaur(string type)
        {
            attackPower = 20;
            health = 100;
            energy = 50;
            this.type = type;
        }
        //Member Mehtods


    }
}
