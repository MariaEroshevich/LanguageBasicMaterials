using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPInheritance
{
    internal class Bike : Transport
    {
        private string _color;

        public Bike(string transportType, string mark, double price, string color): base(transportType, mark, price)
        {
            _color = color;
        }

        public Bike() : base()
        {

        }

        public string Color
        {
            get { return _color; }
        }

        public new string TransportType
        {
            get { return _color + "Move"; }
        }

        public override void GetFuelType()
        {
            Console.WriteLine("Foot fuel");
            base.GetFuelType();
        }

        public new void Move()
        {
            Console.WriteLine("Move on the road");
            base.Move();
        }
    }
}