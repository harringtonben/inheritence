using System;

namespace Inheritance.Pieces.Legs
{
    class Shorts : LegBase, IMove //can implement as many interfaces as you would like
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Shorts Jumped {howHigh} feet in the air");
        }

        public void Run(int howFar)
        {
            Console.WriteLine($"Shorts ran {howFar} miles in the snow, both ways uphill.");
        }
    }

}
