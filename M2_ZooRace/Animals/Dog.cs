using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ZooRace.Animals
{
    class Dog: Animal
    {
        public bool IsBeagleDog { get; set; }

        public Dog(double startPosition, bool isBeagleDog) : base(startPosition)
        {
            Velocity = 2.777777777778; // avg. m/s
            IsBeagleDog = isBeagleDog;
        }

        public Dog(double startPosition) : this(startPosition, false) { }

        public override double Move(int time)
        {
            return StartPosition + (IsBeagleDog ? 2 * Velocity : Velocity * time);
        }

        public override void DisplayDistance(int time)
        {
            Console.WriteLine($"{this.GetType()}: {Move(time)} m");
        }
    }
}
