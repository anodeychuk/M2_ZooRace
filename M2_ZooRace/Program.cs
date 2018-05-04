using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M2_ZooRace.Animals;

namespace M2_ZooRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Race of animals");
            int startPosition = 0;
            int time = 5; // sec
            Console.WriteLine($"time of racing is {time}");

            new Dog(startPosition).DisplayDistance(time);
            new GreyhoundDog(startPosition, true).DisplayDistance(time);

            new Bird(100, 0.5, startPosition).DisplayDistance(time); // 60 deg = 0.5 rad
            new PeregrineFalcon(100, 0.5, startPosition, true).DisplayDistance(time);

            new Rabbit(startPosition).DisplayDistance(time);
            new Hare(startPosition).DisplayDistance(time);

            new Turtle(startPosition, false).DisplayDistance(time);
            new SeaTurtle(startPosition, true).DisplayDistance(time);
        }
    }
}
