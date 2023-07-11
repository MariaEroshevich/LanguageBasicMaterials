using System.ComponentModel.DataAnnotations;
using CSharpAdvanced;

static class Program
{
    static void Main()
    {
        //var intArr = new List<int> { 1, 2, 3 };
        //var stringArr = new List<string> { "one", "two", "three" };
        //var doubleArr = new List<double> { 1.2, 3.4, 5.6 };

        //PrintArray(intArr.ToArray());
        //PrintArray(stringArr.ToArray());
        //PrintArray(doubleArr.ToArray());

        //var firstNumber = 1;
        //var secondNumber = 2;
        //var maxNumber = Max(firstNumber, secondNumber);

        //var firstNumberDouble = 1.3;
        //var secondNumberDouble = 2.4;
        //var maxNumberDouble = Max(firstNumberDouble, secondNumberDouble);

        //var maxNumberMixed1 = Max(firstNumberDouble, secondNumber);
        //var maxNumberMixed2 = Max(firstNumber, secondNumberDouble);

        var pug = new Pug("Patrick");
        var puddle = new Puddle("Artemon");

        Bark(pug);
        Bark(puddle);

        var stringToReview = "Hello world";
        var symbolToFind = 'o';

        stringToReview.GetCharCount(symbolToFind);
        StringHelper.GetCharCount(stringToReview, symbolToFind);

        var newUserRequestBody = new AuthorizationBuilder().AddScheme().AddSignature().AddUserName();
        var oldUserRequestBody = new AuthorizationBuilder().AddSignature().AddUserName();
    }

    public static void Bark<T>(T dog) where T : Dog
    {
        dog.Bark();
    }



    public static void PrintArray<T>(T[] arrayToPrint)
    {
        foreach (var item in arrayToPrint)
            Console.WriteLine(item);
    }

    //public static void PrintArray(int[] arrayToPrint)
    //{
    //    foreach (var item in arrayToPrint)
    //        Console.WriteLine(item);
    //}

    //public static void PrintArray(string[] arrayToPrint)
    //{
    //    foreach (var item in arrayToPrint)
    //        Console.WriteLine(item);
    //}

    //public static void PrintArray(double[] arrayToPrint)
    //{
    //    foreach (var item in arrayToPrint)
    //        Console.WriteLine(item);
    //}


    public static T Max<T>(T x, T y) where T : IComparable<T>
    {
        return x.CompareTo(y) > 0 ? x : y;
    }

    public static void TestBoughtItem()
    {
        var boughtListingPage = new ListingPage<BoughtItem>();
        var item = boughtListingPage.GetCard();
        item.CheckDesign();
    }

    public static void TestFreeItems()
    {
        var boughtListingPage = new ListingPage<FreeItem>();
        var item = boughtListingPage.GetCard();
        item.CheckDesign();
    }
}

public abstract class BaseCartItem
{
    public string Title { get; set; }

    public void Click()
    {

    }

    public abstract void CheckDesign();
}

public class BoughtItem : BaseCartItem
{
    public DateTime BoughtDate { get; set; }

    public override void CheckDesign()
    {
        //Check bought date
    }
}

public class FreeItem : BaseCartItem
{
    public double Sale { get; set; }

    public override void CheckDesign()
    {
        // check sale
    }
}

public class ListingPage<T> where T : BaseCartItem
{
    public List<T> Items { get; set; }

    public void ClickOnItem(string title)
    {
        Items.FirstOrDefault(i => i.Title.Equals(title))?.Click();
    }

    public T GetCard() => Items.First();
}

public class BoughtListingPage
{
    public List<BoughtItem> Items { get; set; }

    public void ClickOnItem(string title)
    {
        Items.FirstOrDefault(i => i.Title.Equals(title))?.Click();
    }

    public BoughtItem GetCard() => Items.First();
}

public class FreeListingPage
{
    public List<FreeItem> Items { get; set; }

    public void ClickOnItem(string title)
    {
        Items.FirstOrDefault(i => i.Title.Equals(title))?.Click();
    }

    public FreeItem GetCard() => Items.First();
}
