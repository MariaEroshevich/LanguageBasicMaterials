using CSharpAdvanced;
using CSharpOOP;
using Calculator = CSharpAdvancedDelegatesDynamic.Calculator;

static class Program
{
    static void Main()
    {
        //Dynamic();

        var jennyThePuddle = new Puddle("Jenny");

        dynamic vaccinatedStatus = true;
        jennyThePuddle.SetVaccinationStatus(vaccinatedStatus);
        Console.WriteLine($"Vaccinated status is {jennyThePuddle.IsVaccinated}");

        dynamic vaccinatedStatusString = "No";
        jennyThePuddle.SetVaccinationStatus(vaccinatedStatusString);
        Console.WriteLine($"Vaccinated status is {jennyThePuddle.IsVaccinated}");


        var bark = jennyThePuddle.Bark;
        bark();

        DoMathOperation doMathOperation = Calculator.Add;
        doMathOperation += Calculator.Multiply;
        doMathOperation += Calculator.Multiply;
        doMathOperation += Calculator.Subtract;

        int result = doMathOperation(4, 5);
        Console.WriteLine(result);

        ExecuteMathOperation(5, 6, doMathOperation);

        writerDelegate("Hello students!");

        var lambdaDelegate = (string message) => Console.WriteLine(message);

        lambdaDelegate("Hello");
        lambdaDelegate("Dear");
        lambdaDelegate("Students");

        DoMathOperation multiply1 = (x, y) => x * y;
        DoMathOperation substract = (x, y) => x - y;
        DoMathOperation sum = (x, y) => x + y;
        DoMathOperation divide = (x, y) => x / y;


        var multiply2 = (int x, int y) => x * y;

        var multResult1 = multiply1(6, 6);
        var multResult2 = multiply2(6, 6);

        ExecuteMathOperation(6, 10, Calculator.Add);
        ExecuteMathOperation(6, 10, substract);
        ExecuteMathOperation(6, 10, sum);
        ExecuteMathOperation(6, 10, divide);

        Predicate<int> isPositive = (int x) => x > 0;
        Console.WriteLine(isPositive(5));

        var animals = new List<string> { "Zebra", "Elephant", "Cat", "Dog", "Lion", "Giraffe", "Parrot" };


        bool listHasParrot = animals.Any(a => a.Equals("Parrot"));

        Func<int, int, int> sumFunc = (x, y) => x + y;
        Console.WriteLine(sumFunc(4, 6));
    }

    public static void Dynamic()
    {
        dynamic obj = 3;
        Console.WriteLine(obj);

        obj = "Hello world!";
        Console.WriteLine(obj);

        object ob = 24;
        dynamic dn = 24;

        //ob += 4;
        //dn += 4;
    }

    // (список параметров) => выражение

    public static void ExecuteMathOperation(int a, int b, Action<int, int> delegateFunc)
    {
        delegateFunc(a, b);
    }

    private static ConsoleWriterDelegate writerDelegate = delegate(string message)
    {
        Console.WriteLine(message);
    };

    public static void ExecuteMathOperation(int a, int b, DoMathOperation operation)
    {
        Console.WriteLine(operation(a, b));
    }

  

    delegate void ConsoleWriterDelegate(string message);

    delegate void BarkDelegate();

    public delegate int DoMathOperation(int x, int y);
}
