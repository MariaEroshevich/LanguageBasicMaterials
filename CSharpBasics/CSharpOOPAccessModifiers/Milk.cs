namespace CSharpOOPAccessModifiers
{
    public class Milk
    {
        public int Percent;
        public string Name;

        public Milk()
        {

        }

        public Milk(int percent)
        {
            Percent = percent;
        }

        public Milk(string name, int percent)
        {
            Name = name;
            Percent = percent;
        }

        public void PrintMilkPercent()
        {
            Console.WriteLine(Percent);
        }
    }
}
