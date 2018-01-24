using System;

namespace Inheritance.Pieces.Legs
{
    class Shorts : LegBase, IMoveable //can implement as many interfaces as you would like
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public int HowFarIMoved { get; private set; }

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Shorts Jumped {howHigh} feet in the air");
        }

        public void Run(int howFar)
        {
            HowFarIMoved += howFar;
            Console.WriteLine($"Shorts ran {howFar} miles in the snow, both ways uphill.");
        }

        public override void Walk(int numberOfSteps)
        {
            HowFarIMoved += numberOfSteps;
            base.Walk(numberOfSteps);
        }
    }

}
