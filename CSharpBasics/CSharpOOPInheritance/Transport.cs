using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPInheritance
{
    public class Transport
    {
        private string _transportType;
        private string _mark;
        private double _price;

        public Transport() { }

        public Transport(string transportType, string mark, double price)
        {
            _transportType = transportType;
            _mark = mark;
            _price = price;
        }

        public string TransportType
        {
            get { return _transportType; }
        }

        public string Mark
        {
            get { return _mark; }
        }

        public double Price
        {
            get { return _price; }
        }

        public void Move()
        {
            Console.WriteLine("Move");
        }

        public virtual void GetFuelType()
        {
            Console.WriteLine("No fuel");
        }

        public void GetColor()
        {
            Console.WriteLine("Blue");
        }
    }
}
