using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    interface IMoveable //an interface what a class should look like but not what it does and is ALWAYS public
    {
        int HowFarIMoved { get; }

        void Walk(int howManySteps);
        void Jump(int howHigh);
        void Run(int howFar);
    }
}
