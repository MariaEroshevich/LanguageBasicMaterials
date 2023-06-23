using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPInheritance.Interface
{
    public interface IMoveble
    {
        //public string TypeOfMovement { get; set; }

        public void Move();

        public static void Run()
        {
            Console.WriteLine("Run");
        }
    }
}
