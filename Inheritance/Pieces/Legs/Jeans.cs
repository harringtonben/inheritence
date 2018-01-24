
using System;

namespace Inheritance.Pieces.Legs
{
    class Jeans : LegBase, IMove
    {
        public override void Jump(int howHigh)
        {
            Console.WriteLine("I don't jump");
        }

        public void Run(int howFar)
        {
            Console.WriteLine($"Jeans ran {howFar} feet before cramping up due to lack of exercise.");
        }
    }

}
