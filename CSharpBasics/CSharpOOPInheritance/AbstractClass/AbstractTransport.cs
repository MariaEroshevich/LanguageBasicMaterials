using CSharpOOPInheritance.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPInheritance.AbstractClass
{
    internal abstract class AbstractTransport
    {
        private string _transportType;
        private string _mark;
        private double _price;

        public AbstractTransport() { }

        public AbstractTransport(string transportType, string mark, double price)
        {
            _transportType = transportType;
            _mark = mark;
            _price = price;
        }

        public abstract string TransportType { get; set; }

        public string Mark
        {
            get { return _mark; }
        }

        public double Price
        {
            get { return _price; }
        }

        public abstract void GetColor();

        public virtual void GetFuelType()
        {
            Console.WriteLine("No fuel");
        }
    }
}
