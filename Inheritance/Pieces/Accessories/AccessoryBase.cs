using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Accessories
{
    abstract class AccessoryBase
    {
        public abstract AccessoryLocation Location { get; }
    }

    enum AccessoryLocation
    {
        Hand=1,
        Torso
    }
}
