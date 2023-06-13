using CSharpOOP;
using CSharpOOPAccessModifiers;


static class Program
{
   
    static void Main()
    {
        IceCream goshaIceCream = new IceCream();
        goshaIceCream.Name = "Gosha";
        goshaIceCream.Price = 2.5;
        goshaIceCream.Taste = "Vanilla";
        goshaIceCream.Weight = 100;

        goshaIceCream.PrintIceCream();

        var noirIceCream = new IceCream
        {
            //noirIceCream.Name = "Noir";
            Price = 4.5,
            Taste = "Chocolate",
            Weight = 200,
        };

        noirIceCream.PrintIceCream();

        IceCream alenkaIceCream = new IceCream("Alenka");
        alenkaIceCream.PrintIceCream();

        Milk milk = new Milk();
        milk.PrintMilkPercent();
    }
}

public class Oop1LessonMaterials
{
    public void Main()
    {
        string itemName1 = Console.ReadLine();
        double unitPrice1 = int.Parse(Console.ReadLine());
        double discount1 = int.Parse(Console.ReadLine());

        CountDiscount(itemName: itemName1, price: unitPrice1);

        //double totalPrice = CountDiscount(unitPrice, discount);
        //Console.WriteLine($"Your Item [{itemName}] price is [{totalPrice}]");

        //string itemName1 = Console.ReadLine();
        //double unitPrice1 = int.Parse(Console.ReadLine());
        //double discount1 = int.Parse(Console.ReadLine());

        //double totalPrice1 = unitPrice1 - (unitPrice1 * discount1 / 100);

        //Console.WriteLine($"Your Item [{itemName1}] price is [{totalPrice1}]");

        //string itemName2 = Console.ReadLine();
        //double unitPrice2 = int.Parse(Console.ReadLine());
        //double discount2 = int.Parse(Console.ReadLine());

        //double totalPrice2 = unitPrice2 - (unitPrice2 * discount2 / 2);

        //Console.WriteLine($"Your Item [{itemName2}] price is [{totalPrice2}]");

        var obj = new List<string>();
        CoutPerimetr("triange", 12, 34, 18, 45, 23);

        GetUser();
        GetUser(20);
        GetUser();

        int x = 5;
        int y = 6;
        int z = Math.Max(x, y);
    }

    static double CountDiscount(double price, double expectedDiscount = 15)
    {
        double totalPrice = price - (price * expectedDiscount / 100);
        return totalPrice;
    }

    static void CountDiscount(double price, string itemName, double expectedDiscount = 15, params int[] listOfSideLength)
    {
        double totalPrice = price - (price * expectedDiscount / 100);
        Console.WriteLine($"Your Item [{itemName}] price is [{totalPrice}]");
    }

    static void CountDiscountWithConsole()
    {
        string itemName = Console.ReadLine();
        double unitPrice = int.Parse(Console.ReadLine());
        double discount = int.Parse(Console.ReadLine());
        double totalPrice = unitPrice - (unitPrice * discount / 100);
        Console.WriteLine($"Your Item [{itemName}] price is [{totalPrice}]");
    }

    static void CoutPerimetr(string itemName, params int[] listOfSideLength)
    {
        int perimetr = 0;

        foreach (var side in listOfSideLength)
        {
            perimetr = perimetr + side;
        }
    }

    static void CountTriangle(int a, int b, int c)
    {
        int perimetr;
        perimetr = a + b + c;
        Console.WriteLine(perimetr);
    }

    static void CountSquare(int a, int b, int c, int d)
    {
        int perimetr;
        perimetr = a + b + c + d;
        Console.WriteLine(perimetr);
    }

    static string GetUser(int users = 100)
    {
        // ApiSetup().GetFilteredUsers(users)
        //// GetFilteredUsers(int 100)
        return string.Empty;
    }


}