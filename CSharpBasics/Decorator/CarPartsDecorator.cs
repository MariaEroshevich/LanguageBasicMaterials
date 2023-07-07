using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CarPartsDecorator : Car
    {
        private Car _car;
        
        public CarPartsDecorator(Car car)
        {
            _car = car;
        }

        public Car Car { get { return _car; } }
    }
}
