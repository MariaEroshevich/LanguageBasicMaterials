using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public static class PenHelper
    {
        public static void PrintPen(this Pen pen)
        {
            Console.WriteLine("Successfully printed!");
        }

        public static void ChangePen(this Pen pen)
        {
            Console.WriteLine("Pen changed!");
        }
    }
}
