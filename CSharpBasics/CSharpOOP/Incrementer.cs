using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class Incrementer
    {
        private Incrementer()
        {
        }

        public static int CurrentNumber;

        public static int Increment()
        {
            return ++CurrentNumber;
        }
    }
}
