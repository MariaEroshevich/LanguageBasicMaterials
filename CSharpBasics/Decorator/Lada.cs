using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Lada : Car
    {
        public Lada(string description) : base(description) { }

        public override decimal GetPrice()
        {
            return 40.000m;
        }
    }
}
