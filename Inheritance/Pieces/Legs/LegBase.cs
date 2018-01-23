using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Legs
{
    abstract class LegBase //doesn't allow anyone to modify, and cannot create a legbase without inheriting from this. Most base classes will be like this
    {
        public int NumberOfPockets { get; set; }
        public string Color { get; set; }
        public LegSize Size { get; set; }

        public virtual void Walk(int numberOfSteps) //this is something that people who inherit from me can change if they want to
        {
            Console.WriteLine($"The {Size} legs wearing a {GetType().Name} took {numberOfSteps} steps.");
        }
    }
}
