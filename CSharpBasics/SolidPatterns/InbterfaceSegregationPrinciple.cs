using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns
{
    //Bad architecture
    public interface IEmployee
    {
        void Work();

        void Eat();
    }

    //Good architecture
    public interface IWorkable
    {
        void Work();
    }

    public interface IFeedable
    {
        void Eat();
    }

    public class Human : IWorkable, IFeedable
    { 
        public void Work()
        {
            Console.WriteLine("Work");
        }

        public void Eat()
        {
            Console.WriteLine("Eat");
        }
    }

    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Work");
        }
    }
}
