using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ZooRace.Animals
{
    class Turtle: Animal
    {
        public bool IsAfraid { get; set; }
        public double VelocityAfraid { get; protected set; }

        public Turtle(double startPosition, bool isAfraid) : base(startPosition)
        {
            Velocity = 0.5; // avg m/s
            VelocityAfraid = 2.777777777778; // m/s
            IsAfraid = isAfraid;
        }

        public override double Move(int time)
        {
            if (IsAfraid)
                return StartPosition + VelocityAfraid * time;
            else
                return StartPosition + Velocity * time;
        }

        public override void DisplayDistance(int time)
        {
            Console.WriteLine($"{this.GetType()}: {Move(time)}");
        }

    }
}
