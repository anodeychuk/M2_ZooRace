using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ZooRace.Animals
{
    class Hare: Rabbit
    {
        public Hare(double startPosition): base(startPosition)
        {
            Velocity = 16.66666666667; // avg. m/s
        }

        public new double Move(int time)
        {
            return StartPosition + Velocity * time;
        }

        public override void DisplayDistance(int time)
        {
            Console.WriteLine($"{this.GetType()}: {Move(time)}");
        }
    }
}
