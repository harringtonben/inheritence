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
    class Program
    {
        static void Main(string[] args)
        {
            var jeans = new Jeans
            {
                Color = "Black",
                Size = LegSize.Adult,
                NumberOfPockets = 4
            };

            var head = new Emmet
            {
                EyeColor = "Blue",
                Happy = true,
                HeadGear = new Hair { Color = "Blonde", Length = "Long" }
            };

            var body = new DadBod
            {
                BeerBelly = true,
                BodyHair = true,
                NumberOfNipples = 2,
                Shirt = "Hawaiin"

            };

            var dademmet = new MiniFigure(jeans, head, body, "Emmet");

            dademmet.Walk(50);

            dademmet.SwapTorso(null);

            Console.ReadLine();
        }
    }
}
