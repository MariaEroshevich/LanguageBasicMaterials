using CSharpOOPAccessModifiers;
using System.Xml.Linq;

namespace CSharpOOP
{
    public class IceCream : Milk
    {
        public const double TaxConst = 0.15; // compilation stage

        public readonly double TaxReadonly; // execution stage

        static IceCream()
        {
            MainIngredient = "Milk";
        }

        public IceCream(string name)
        {
            Name = $"Ice cream name {name}";
            TaxReadonly = 0.2;
        }

        public IceCream(string name, int weight)
        {
            Name = name;
            Weight = weight;
            Percent = 20;
        }

        public static string MainIngredient { get; set; }

        private string _name = "Undefined";
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = $"Ice cream name {value.Trim()}";
            }
        }

        //public string Name { get; set; }

        public string Taste { get; set; }
        internal int Weight;

        private double _price = 15;
        public double Price
        {
            get
            {
                return _price - _price * Tax;
            }
        }

        private string _secretIngredient;
        public string SecretIngredient
        {
            set
            {
                _secretIngredient = value;
            }
        }

        public static string NameConst(string name) => $"Product.inc {name}";

        public IceCream CreateMockIceCream()
        {
            var mockIceCream = new IceCream("Mock_Ice_Cream") { Name = "Mock_Ice_Cream", _price = 100, Taste = "Mocked_Taste", Weight = 1000 };

            return mockIceCream;
        }

        public static void PrintIceCream(IceCream iceCream)
        {
            Console.WriteLine(
                $"Ice cream name is {iceCream.Name} with price {iceCream.Price} with taste {iceCream.Taste} and weight {iceCream.Weight}!");
        }

        public void PrintIceCream()
        {
            Console.WriteLine(
                $"Ice cream name is {Name} with price {_price} with taste {Taste} and weight {Weight}!");
        }
    }
}
