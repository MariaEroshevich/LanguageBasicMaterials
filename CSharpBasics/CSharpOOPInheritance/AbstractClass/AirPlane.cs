using CSharpOOPInheritance.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPInheritance.AbstractClass
{
    internal abstract class AirPlane : AbstractTransport, IMoveble
    {
        private string _color;
        private string _fuelType;

        public AirPlane() : base()
        {

        }

        public AirPlane(string transportType, string mark, double price, string color,
            string fuelType) : base(transportType, mark, price)
        {
            _color = color;
            _fuelType = fuelType;
        }

        public string Color => _color;

        public string FuelType => _fuelType;

        public override string TransportType
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }

        //abstract method
        public override abstract void GetColor();

        //virtual method
        public override void GetFuelType()
        {
            base.GetFuelType();
            Console.WriteLine($"Fuel type is {FuelType}");
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Transport type is {TransportType}; transport mark is {Mark};"
                + $"transport price is {Price}");
        }

        public void Move()
        {
            Console.WriteLine("Fly");
        }
    }
}
