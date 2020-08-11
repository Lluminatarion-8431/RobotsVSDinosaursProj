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
            InitializeFleetAndHerd();
        }
        //Member Mehtods (Can Do)
        public void InitializeFleetAndHerd()
        {
            fleet = new Fleet();
            herd = new Herd();
        }
        public void DinosaursTurn(Dinosaur dinosaur)
        {
            Console.WriteLine(dinosaur.type + " is attacking yo!");
            DisplayAttackOptions(true);
            int userChoice = Convert.ToInt32(Console.ReadLine());
            dinosaur.Attack(fleet.robots[userChoice]);
            if (fleet.robots[userChoice].health <= 0)
            {
                Console.WriteLine(herd.dinosaurs[userChoice].type + " has been murdered hahaha.");
                fleet.robots.Remove(fleet.robots[userChoice]);
            }
        }
        public void RobotsTurn(Robot robot)
        {
            Console.WriteLine(robot.name + " is attacking yo!");
            DisplayAttackOptions(false);
            int userChoice = Convert.ToInt32(Console.ReadLine());
            robot.Attack(herd.dinosaurs[userChoice]);
            if (herd.dinosaurs[userChoice].health <= 0)
            {
                Console.WriteLine(fleet.robots[userChoice].name + " has been murdered hahaha.");
                herd.dinosaurs.Remove(herd.dinosaurs[userChoice]);
            }
        }
        public void DisplayAttackOptions(bool dinosaursTurn)
        {
            Console.WriteLine("Who do you want to destroy?:");
            if (dinosaursTurn)
            {
                for(int i = 0; i < fleet.robots.Count; i++)
                {
                    Console.WriteLine(i + ") " + fleet.robots[i].name);
                }
            }
            else
            {
                for(int i = 0; i < herd.dinosaurs.Count; i++)
                {
                    Console.WriteLine(i + ")" + herd.dinosaurs[i].type);
                }
            }
        }
        public void SimulateBattle()
        {
            bool dinosaursTurn = true;
            while (fleet.robots.Count > 0 && herd.dinosaurs.Count > 0)
            {
                if (dinosaursTurn)
                {
                    DinosaursTurn(herd.dinosaurs[0]);
                    dinosaursTurn = false;
                }
                else
                {
                    RobotsTurn(fleet.robots[0]);
                    dinosaursTurn = true;
                }
            }
        }
        public void DisplayWinner()
        {
            if(fleet.robots.Count > 0)
            {
                Console.WriteLine("Robots got murdered!");
            }
            else
            {
                Console.WriteLine("Dinosaurs got murdered!");
            }
        }
        public void PromptToPlayAgain()
        {
            Console.WriteLine("Up for another round? Y/N");
            string userInput = Console.ReadLine();
            if (userInput == "Yes" || userInput == "yes" || userInput == "Y" || userInput == "y")
            {
                InitializeFleetAndHerd();
                Run();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public void Run()
        {
            SimulateBattle();
            DisplayWinner();
            PromptToPlayAgain();
        }
    }
}
