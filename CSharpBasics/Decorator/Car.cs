using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Car
    {
        private string _description;

        public Car()
        {
            
        }

        public Car(string description)
        {
            _description = description;
        }

        public virtual string GetDescription()
        {
            return _description;
        }

        public abstract decimal GetPrice();
    }
}
