using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Pieces.Legs;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var shorts = new Shorts
            {
                Color = "Tan",
                Length = Length.School,
                Size = LegSize.Baby,
                NumberOfPockets = 6
            };

            var jeans1 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Adult,
                NumberOfPockets = 4
            };

            var jeans2 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Child,
                NumberOfPockets = 4
            };

            var jeans3 = new Jeans
            {
                Color = "Black",
                Size = LegSize.Baby,
                NumberOfPockets = 4
            };

            var skirt1 = new Skirt
            {
                Color = "Rainbow",
                Size = LegSize.Child,
                NumberOfPockets = 0,
                Material = "Stretchy",
                Length = Length.Church
            };

            var skirt2 = new Skirt
            {
                Color = "Sparkly",
                Size = LegSize.Adult,
                NumberOfPockets = 0,
                Material = "Fishnet",
                Length = Length.StreetCorner
            };

            var movers = new List<LegBase>
            {
                shorts,
                skirt1,
                skirt2,
                jeans1,
                jeans2,
                jeans3
            };

            foreach (var mover in movers)
            {
                mover.Walk(10);
                mover.Jump(10);
                mover.Run(15);

                //if (leg is Skirt) boolean check
                //{
                //var skirt = (Skirt) leg;
                //}

                //var skirt = leg as Skirt; 
                //if (leg != null) //implicite type conversion
                //{
                //    skirt.Material
                //}

                //if (leg is Skirt skirt) //pattern matching
                //{
                //    skirt.Material = "jeans";
                //}

                switch (mover) //where pattern matching will happen most often
                {
                    case Skirt s:
                        Console.WriteLine($"It's a skirt made of {s.Material}");
                        break;
                    case Jeans j:
                        Console.WriteLine($"It's {j.Color} jeans");
                        break;
                    //case IMove m:
                    //    m.Run(15);
                    //    break; This would only work if the first 2 statements in the switch did not run, otherwise it would never make it out of here.
                }

            }
            Console.Read();
        }
    }
}
