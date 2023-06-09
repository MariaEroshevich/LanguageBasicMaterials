namespace CSharpBasics
{
    public class DataTypes
    {
        public void Variables()
        {
            char class1 = 'c';
            Console.WriteLine("Our variable is" + class1);

            var person = new Person();
            var firstA = person.a;
            var lastA = person.Walk();
        }

        public void DataTypesEquality()
        {
            int a = 5;
            int b = 5;
            bool c = a.Equals(b); // True
            bool d = a == b; // True
            Console.WriteLine("Equals " + c);
            Console.WriteLine("==  " + d);

            object e = 5;
            object f = 5;
            bool g = e.Equals(f); // True
            bool i = e == f; // False
            Console.WriteLine("Equals " + g);
            Console.WriteLine("==  " + i);

            int j = 5;
            object k = 5;
            var l = j.Equals(k); // True
            //var m = j == k;

            int n = 5;
            double o = 5;
            bool p = o == n;
            Console.WriteLine("==  " + p);
        }

        public void StringsReview()
        {
            Console.WriteLine("Enter your age:");
            var age = Console.ReadLine();

            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            string greeting = string.Format("Hello, {0}, your age is {1}!", name, age);
            //var isContains = greeting.Contains(name);
            var changedGreeting = greeting.Replace("Hell111o", "Bye");
            Console.WriteLine(changedGreeting);
        }

        public void WorkWithConsole()
        {
            Console.WriteLine("Enter your age:");
            var age = Console.ReadLine();

            int convertedAge = 0;
            //var convertedAge = Convert.ToInt32(age);
            //var convertedAge = int.Parse(age);

            int.TryParse(age, out convertedAge);


            double a = 15;
            a = a + 1;

            //var poem = "roses are red";
            //var poem2 = "sky is blue";
            //var poem3 = poem + poem2;

            if (convertedAge < 18)
            {
                Console.WriteLine("Too young");
            }
            else
            {
                Console.WriteLine("Too old!");
            }
        }

        public void ShowDataTypes()
        {
            #region Типы данных

            string line = "Type {0, 8} |\t.NET {1, 8} |\tSize ={2} \t| Min = {3, 30}\t| Max = {4}";

            Console.Title = "Data types C#";

            Console.WriteLine("\n\t\t\t\t\tValue types C# \n");

            Console.WriteLine("\n\t\t\t\t\tIntegral numeric types: \n");

            Console.WriteLine(line, "byte", nameof(Byte), sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine(line, "sbyte", nameof(SByte), sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine(line, "short", nameof(Int16), sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine(line, "ushort", nameof(UInt16), sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine(line, "int", nameof(Int32), sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine(line, "uint", nameof(UInt32), sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine(line, "long", nameof(Int64), sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine(line, "ulong", nameof(UInt64), sizeof(ulong), ulong.MinValue, ulong.MaxValue);

            Console.WriteLine("\n\t\t\t\t\tFloating-point numeric types: \n");

            Console.WriteLine(line, "float", nameof(Single), sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine(line, "double", nameof(Double), sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine(line, "decimal", nameof(Decimal), sizeof(decimal), decimal.MinValue, decimal.MaxValue);

            Console.WriteLine("\n\t\t\t\t\tChar types: \n");

            Console.WriteLine(line, "char", nameof(Char), sizeof(char), char.MinValue, char.MaxValue);

            Console.WriteLine("\n\t\t\t\t\tBoolean types: \n");

            Console.WriteLine(line, "bool", nameof(Boolean), sizeof(bool), bool.FalseString, bool.TrueString);

            Console.WriteLine("\n\t\t\t\t\tReference types C# \n");

            Console.WriteLine(line, "string", nameof(String), "N/A", "N/A", "N/A");
            Console.WriteLine(line, "object", nameof(Object), "N/A", "N/A", "N/A");
            Console.WriteLine(line, "dynamic", "N/A", "N/A", "N/A", "N/A");

            #endregion
        }
    }

    class Person
    {
        public int a = 5;

        public int Walk()
        {
            int a = 4;
            return a;
        }
    }
}
