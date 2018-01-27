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
        LegBase _legs;
        HeadBase _head;
        TorsoBase _torso;

        public MiniFigure(LegBase legs, HeadBase head, TorsoBase torso, string name)
        {
            _legs = legs;
            _head = head;
            _torso = torso;
            Name = name;
        }

        public void Walk(int numberofsteps)
        {
            switch (_head.HeadGear)
            {
                case Hair hair:
                    Console.WriteLine($"{Name} tossed his {hair.Length} {hair.Color} in the wind");
                    break;
                case Helmet helmet:
                    Console.WriteLine($"{Name} wondered why he is wearing a {helmet.Color} helmet. He is just going on a walk");
                    break;
            }
            _legs.Walk(numberofsteps);
        }

        public void SwapTorso(TorsoBase torso)
        {
            if (torso == null)
            {
                throw new ArgumentNullException(nameof(torso));
            }
        }
    }
}
