//int j = 0;
//try
//{
//    int i = 5;
//    j = i / 0;
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.ToString());
//}
//finally
//{
//    Console.WriteLine(j);
//}

//int number1;
//int number2;
//int result;

//try
//{
//    Console.WriteLine("Enter first number:");
//    number1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter second number:");
//    number2 = int.Parse(Console.ReadLine());

//    result = number1 / number2;
//    Console.WriteLine($"Result: {result}");
//}
//catch(FormatException ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine("Only integer numbers allowed");
//}
//catch(DivideByZeroException ex)
//{
//    Console.WriteLine("Divided to zero is forbidden");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine("Only integer numbers allowed");
//}

//Console.WriteLine("Divided passes successfully");

//try
//{
//    int[] numberList = new int[5];
//    var x = numberList[7] / 0;
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}

try
{
    Console.WriteLine("Enter string value:");
    string name = Console.ReadLine();

    if (name == null || name.Length < 3)
    {
        throw new Exception("My own message");
    }

    else
    {
        Console.WriteLine($"name = {name}");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

