using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class WoodDeveloper : Developer
    {
        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
