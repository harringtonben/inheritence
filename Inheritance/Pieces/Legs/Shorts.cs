using System;

namespace Inheritance.Pieces.Legs
{
    class Shorts : LegBase
    {
        public string Material { get; set; }
        public Length Length { get; set; }

        public override void Jump(int howHigh)
        {
            Console.WriteLine($"Shorts Jumped {howHigh} feet in the air");
        }
    }
}
