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
        public Weapon weapon;
        //Constructor
        public Robot(string name)
        {
            health = 100;
            weapon = new Weapon("Sword");
            powerLevel = 100;
            this.name = name;
        }
        //Member Mehtods
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
        }
      

        //public void Attack(Robot robot)
        //{
        //    robot.powerLevel -= 10;
        //}
    }
}
