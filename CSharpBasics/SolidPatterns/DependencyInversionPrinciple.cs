using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPatterns
{
    public class DependencyInversionPrinciple
    {
        public interface IEmployee
        {
            void Work();
        }

        public class Human : IEmployee
        {
            public void Work()
            {
                Console.WriteLine("Human");
            }

            public void Eat()
            {
                Console.WriteLine("Eat");
            }
        }

        public class Robot : IEmployee
        {
            public void Work()
            {
                Console.WriteLine("Work");
            }
        }

        public class Manager
        {
            private List<IEmployee> _employees;

            public Manager(List<IEmployee> employees)
            {
                _employees = employees;
            }

            public void Manage()
            {
                foreach (var employee in _employees)
                {
                    employee.Work();
                }
            }
        }
    }
}
