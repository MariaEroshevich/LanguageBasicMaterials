using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public struct Structure
    {
        public string Name;

        public Structure(string name)
        {
            Name = name;
        }

        public void GetName()
        {
            Console.WriteLine(Name);
        }
    }
}
