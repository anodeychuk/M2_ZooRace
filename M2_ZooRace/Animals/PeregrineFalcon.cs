using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ZooRace.Animals
{
    class PeregrineFalcon : Bird
    {
        public bool IsHunterMode { get; set; }
        public double VelocityHunterMode { get; protected set; }
        public PeregrineFalcon(double height, double angle, double startPosition, bool isHunterMode) : base(height, angle, startPosition)
        {
            Velocity = 55.55555555556; // m/s
            VelocityHunterMode = 83.33333333333; // m/s
            IsHunterMode = isHunterMode;
        }

        public new double Move(int time)
        {
            return  StartPosition + (( IsHunterMode ? VelocityHunterMode : Velocity) * time) * Math.Cos(Angle);
        }

        public override void DisplayDistance(int time)
        {
            Console.WriteLine($"{this.GetType()}: {Move(time)}");
        }

    }
}
