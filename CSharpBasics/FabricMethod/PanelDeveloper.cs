using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class PanelDeveloper : Developer
    {
        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
