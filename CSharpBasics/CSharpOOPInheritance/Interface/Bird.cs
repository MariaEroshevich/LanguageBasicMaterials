using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPInheritance.Interface
{
    internal class Bird : IMoveble
    {
        public void Move()
        {
            Console.WriteLine("Fly");
        }
    }
}
