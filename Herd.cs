using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        //Member Variables
        public List<Dinosaur> dinosaurs;

        //Constructor
        public Herd()
        {
            Dinosaur dinosaur1 = new Dinosaur("T-Rex");
            Dinosaur dinosaur2 = new Dinosaur("Velociraptor");
            Dinosaur dinosaur3 = new Dinosaur("Tricederatops");
            dinosaurs = new List<Dinosaur>();
            dinosaurs.Add(dinosaur1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);
        }
        //Member Mehtods
    }
}
