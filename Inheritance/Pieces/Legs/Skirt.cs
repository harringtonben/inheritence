using System;

namespace Inheritance.Pieces.Legs
{
    class Skirt : LegBase, IMoveable
    {
        public string Material { get; set; }
        public Length Length { get; set; }
  
        int _howFarIMoved;
        public int HowFarIMoved
        {
            get => _howFarIMoved;
        }

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Skirt jumped {howHigh} inches in the air");
        }

        public override void Walk(int numberOfSteps) //overrides inheritance
        {
            _howFarIMoved += numberOfSteps;
            if (Length == Length.StreetCorner)
            {
                Console.WriteLine($"The {Size} legs walked suggestively {numberOfSteps} steps and knocked on your window.");
                return; //this will break out of the method so that the next line of code will not execute
            }
            base.Walk(numberOfSteps); //this will return the thing that you are inheriting from..aka take the walk method from the base not the Skirt class.
        }

        public void Run(int howFar)
        {
            _howFarIMoved += howFar;
            Console.WriteLine($"Skirt ran {howFar} miles uphill in the snow.");
        }
    }
}
