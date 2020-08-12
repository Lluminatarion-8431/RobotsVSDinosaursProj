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
            PickUpWeapon();
        }
        //Member Mehtods
        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= weapon.attackPower;
        }


        public void Attack(Robot robot)
        {
            robot.powerLevel -= 10;
        }
        public void PickUpWeapon(/*List<string> weaponType*/)
        {

            //weaponType[0] = "Mighty Axe";
            //weaponType[1] = "Mjöllnir";
            //weaponType[2] = "Excalibur";
            //string[] weapon = { "Mighty Axe", "Mjöllnir", "Excalibur" };
            //foreach (string item in weapon)
            //{
            //    Console.WriteLine(item);
            //    string weaponType = Console.ReadLine();
            //    weapon = new Weapon(weaponType);
            //}

            //Console.WriteLine("Choose weapon type:");
            //string weapon = Console.ReadLine();






            //Randomly choose one from the list
            //this.weapon = new Weapon();
        }
    }
}
