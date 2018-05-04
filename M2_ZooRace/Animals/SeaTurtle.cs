using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_ZooRace.Animals
{
    class SeaTurtle : Turtle
    {
        public double FlowVelocity { get; protected set; }
        public SeaTurtle(double startPosition, bool isAfraid) : base(startPosition, isAfraid)
        {
            FlowVelocity = 1.388888888889; // m/s
            Velocity = 5.555555555556; // avg m/s
            VelocityAfraid = 11.11111111111; // m/s
        }

        public new double Move(int time)
        {
            if (IsAfraid)
                return StartPosition + VelocityAfraid + FlowVelocity * time;
            else
                return StartPosition + Velocity + FlowVelocity * time;
        }

        public override void DisplayDistance(int time)
        {
            Console.WriteLine($"{this.GetType()}: {Move(time)}");
        }

    }
}
