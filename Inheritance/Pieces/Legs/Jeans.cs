
using System;

namespace Inheritance.Pieces.Legs
{
    class Jeans : LegBase
    {
        public override void Jump(int howHigh)
        {
            Console.WriteLine("I don't jump");
        }
    }

}
