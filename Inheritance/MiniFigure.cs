using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Pieces.Heads;
using Inheritance.Pieces.Legs;
using Inheritance.Pieces.Torsos;

namespace Inheritance
{
    class MiniFigure
    {
        public string Name { get; private set; }
        public LegBase Legs { get; private set; }
        public HeadBase Head { get; private set; }
        public TorsoBase Torso { get; private set; }

        public MiniFigure(LegBase legs, HeadBase head, TorsoBase torso, string name)
        {
            Legs = legs;
            Head = head;
            Torso = Torso;
            Name = name;
        }

        public void Walk(int numberofsteps)
        {
            switch (Head.HeadGear)
            {
                case Hair hair:
                    Console.WriteLine($"{Name} tossed his {hair.Length} {hair.Color} in the wind");
                    break;
                case Helmet helmet:
                    Console.WriteLine($"{Name} wondered why he is wearing a {helmet.Color} helmet. He is just going on a walk");
                    break;
            }
            Console.WriteLine($"{Name} ");
            Legs.Walk(numberofsteps);
        }
    }
}
