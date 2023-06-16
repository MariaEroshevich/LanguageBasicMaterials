using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class Pen
    {
        public Pen()
        {
        }

        public static int Length { get; set; }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = $"The color of the pen is {value}";
            }
        }

        private double _price = 320;
        public double Price
        {
            get
            {
                return _price;
            }
        }

        private string _manufacturer;
        public string Manufacturer
        {
            set
            {
                _manufacturer = $"the manufacturer of the pen is {value}";
            }
        }

        public void PrintFeatures()
        {
            Console.WriteLine($"{_color}, price is {_price}, {_manufacturer}");
        }
    }
}
