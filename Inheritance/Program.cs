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
            var dademmet = new MiniFigure(new Jeans(), new Emmet(), new DadBod(), "Emmet");

            dademmet.Walk(50);

            Console.ReadLine();
        }
    }
}
