using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ZooRace.Animals
{
    abstract class Animal
    {
        public double Velocity { get; protected set; }
        public double StartPosition { get; set; }

        public Animal(double startPosition)
        {
            StartPosition = startPosition;
        }

        public abstract double Move(int time);

        public abstract void DisplayDistance(int time);
    }
}
