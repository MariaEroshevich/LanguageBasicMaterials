using CSharpOOPAccessModifiers;

namespace CSharpOOP
{
    public class IceCream : Milk
    {
        public IceCream()
        {
        }

        public IceCream(string name)
        {
            Name = $"Ice cream name {name}";
        }

        public IceCream(string name, int weight)
        {
            Name = name;
            Weight = weight;
            Percent = 20;
        }

        public string Name;
        public string Taste;
        internal int Weight;
        public double Price;

        public IceCream CreateMockIceCream()
        {
            var mockIceCream = new IceCream { Name = "Mock_Ice_Cream", Price = 100, Taste = "Mocked_Taste", Weight = 1000 };

            return mockIceCream;
        }

        public void PrintIceCream(IceCream iceCream)
        {
            Console.WriteLine(
                $"Ice cream name is {iceCream.Name} with price {iceCream.Price} with taste {iceCream.Taste} and weight {iceCream.Weight}!");
        }

        public void PrintIceCream()
        {
            Console.WriteLine(
                $"Ice cream name is {Name} with price {Price} with taste {Taste} and weight {Weight}!");
        }
    }
}
