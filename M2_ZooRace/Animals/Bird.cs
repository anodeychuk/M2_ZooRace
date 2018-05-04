using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ZooRace.Animals
{
    class Bird : Animal
    {
        public double Height { get; set; }
        public double Angle { get; set;  }

        public Bird(double height, double angle, double startPosition) : base(startPosition)
        {
            Velocity = 11.11111111111; // avg m/s
            Height = height;
            Angle = angle;
        }

        public override double Move(int time)
        {
            return StartPosition + (Velocity * time) * Math.Cos(Angle);
        }

        public override void DisplayDistance(int time)
        {
            Console.WriteLine($"{this.GetType()}: {Move(time)}");
        }
    }
}