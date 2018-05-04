using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ZooRace.Animals
{
    class GreyhoundDog: Dog
    {
        public bool IsHunterMode { get; set; }
        public double VelocityHunterMode { get; protected set; }

        public GreyhoundDog(double startPosition, bool isHunterMode) : base(startPosition)
        {
            IsHunterMode = isHunterMode;
            Velocity = 2.777777777778; // avg. m/s
            VelocityHunterMode = 19.44444444444; //  m/s
        }

        public new double Move(int time)
        {
            return StartPosition + (IsHunterMode ? VelocityHunterMode : Velocity) * time;
        }

        public override void DisplayDistance(int time)
        {
            Console.WriteLine($"{this.GetType()}: {Move(time)}");
        }
    }
}
