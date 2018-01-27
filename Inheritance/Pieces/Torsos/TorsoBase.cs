using Inheritance.Pieces.Accessories;
using System.Collections.Generic;

namespace Inheritance.Pieces.Torsos
{
    abstract class TorsoBase
    {
        public string Shirt { get; set; }
        public List<AccessoryBase> Accessories { get; set; } = new List<AccessoryBase>();
    }
}
