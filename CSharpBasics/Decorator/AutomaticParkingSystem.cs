using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AutomaticParkingSystem : CarPartsDecorator
    {
        private string _description;

        private decimal _price;

        public AutomaticParkingSystem(Car car, string description, decimal price) : base(car) 
        { 
            _description = description;
            _price = price;
        }

        public override decimal GetPrice()
        {
            return Car.GetPrice() + _price;
        }

        public override string GetDescription()
        {
            return Car.GetDescription() + _description;
        }
    }
}