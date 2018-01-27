using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Pieces.Accessories
{
    class Backpack : AccessoryBase
    {
        public override AccessoryLocation Location => AccessoryLocation.Torso;
    }
}
