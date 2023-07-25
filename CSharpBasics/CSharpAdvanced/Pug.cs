using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Pug : Dog
    {
        public Pug(string name) : base(name)
        {
        }

        public override void Bark()
        {
            Console.WriteLine($"Tyaf tyaf! I am {Name}!");
        }

        //public override void Bark(int count)
        //{
        //    base.Bark(count + 1);
        //}
    }
}
