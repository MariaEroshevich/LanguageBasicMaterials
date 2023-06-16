using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public static class Calculator
    {
        public static double Add(this double x, double y) => x + y;

        public static double Subtract(this double x, double y) => x - y;

        public static double Multiply(this double x, double y) => x * y;

        public static double Divide(this double x, double y) => x / y;
    }
}
