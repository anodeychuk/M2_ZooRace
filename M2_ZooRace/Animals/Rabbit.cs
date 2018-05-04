using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ZooRace.Animals
{
    class Rabbit:Animal
    {
        public double Omega { get; private set; } 

        public Rabbit(double startPosition) : base(startPosition)
        {
            Velocity = 5.555555555556; // avg. m/s
            Omega = 0.75; // height of the jump
        }

        public override double Move(int time)
        {
            return StartPosition + Omega * Velocity * time;
        }

        public override void DisplayDistance(int time)
        {
            Console.WriteLine($"{this.GetType()}: {Move(time)}");
        }

    }
}
