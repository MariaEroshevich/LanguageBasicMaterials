using CSharpOOPAccessModifiers;

static class Program
{
    static void Main()
    {
        // Where
        var animals = new List<string> { "Zebra", "Elephant", "Cat", "Dog", "Lion", "Giraffe", "Parrot" };
        var modifiedAnimals = ChangeCollection(animals);
        var modifiedAnimalsLinq =
            animals.Where(animal => animal.Contains("o"));//.Select(name => name.Replace("o", "a")).ToList();
        var modifiedAnimalsLinqImmediate = modifiedAnimalsLinq.ToList();

        // Select
        var products = new List<Milk>();
        products.Add(new Milk("Savushkin", 3));
        products.Add(new Milk("Prostokvashino", 2));
        products.Add(new Milk("Brest-Litovsk", 1));

        var milkPercentages = products.Select(m => m.Percent).ToList();

        // Linq
        var milkList = milkPercentages.Select(percentage => new Milk(percentage)).ToList();

        // Equal to Linq
        var milkList1 = new List<Milk>();
        foreach (var percentage in milkPercentages)
        {
            var milk = new Milk(percentage);
            milkList1.Add(milk);
        }

        // Difference
        var milkListSelect = milkPercentages.Select(percentage => percentage < 2).ToList();
        var milkListWhere = milkPercentages.Where(percentage => percentage < 2).ToList();

        Console.WriteLine(string.Join(',', milkPercentages));

    }
    // (x, y, z) => x*y*z
    public static void HelloWorld() => Console.Write("Hello world");

    public static List<string> ChangeCollection(List<string> initialCollection, char oldChar = 'o', char newChar = 'a')
    {
        var modifiedCollection = new List<string>();
        foreach (var animal in initialCollection)
        {
            string modifiedItem = animal.Replace(oldChar, newChar);
            modifiedCollection.Add(modifiedItem);
        }
        return modifiedCollection;
    }
}
