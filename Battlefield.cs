using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //Member Variables (Has a)
        public Fleet fleet;
        public Herd herd;
        //Constructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }
        //Member Mehtods (Can Do)
        public void DinosaursTurn(Dinosaur dinosaur)
        {
            Console.WriteLine(dinosaur.type + " is attacking yo!")
            DisplayAttackOptions("Dinosaurs");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            dinosaur.Attack(fleet.robots[userChoice]);
            if (fleet.robots[userChoice].health <= 0)
            {
                Console.WriteLine(fleet.robots[userChoice].name + " has been murdered hahaha.");
                fleet.robots.Remove(fleet.robots[userChoice]);
            }
        }
        public void RobotsTurn(Robot robot)
        {
            Console.WriteLine(robot.name + " is attacking yo!")
            DisplayAttackOptions("Robots");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            robot.Attack(herd.dinosaurs[userChoice]);
            if (herd.dinosaurs[userChoice].health <= 0)
            {
                Console.WriteLine(herd.dinosaurs[userChoice].type + " has been murdered hahaha.");
                herd.dinosaurs.Remove(herd.dinosaurs[userChoice]);
            }
        }
        public void DisplayAttackOptions()
        {

        }
    }
}
