using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPInheritance.AbstractClass
{
    internal class Ship : AirPlane
    {
        public override void GetColor()
        {
            Console.WriteLine("color");
        }
    }
}
