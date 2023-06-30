using CSharpOOPAccessModifiers;
using LINQ;

static class Program
{
    static void Main()
    {
        IntersectOperators();

        // Where
        var animals = new List<string> { "Zebra", "Elephant", "Cat", "Dog", "Lion", "Giraffe", "Parrot" };
        var modifiedAnimals = ChangeCollection(animals);
        
        // extension syntax
        var modifiedAnimalsLinq =
            animals.Where(animal => animal.Contains("o")).Select(name => name.Replace("o", "a")).ToList();

        // query syntax
        var modifiedAnimalsQuery = from animal in animals
            where animal.Contains('o')
            select animal.Replace('o', 'a');

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


        var cities = new List<string> { "london", "paris", "minsk", "prague", "rome", "vilnius", "saratov" };
        //1. Make all cities names start with capitalized letter. Use extension and query syntax
        //2. Create City class with property Name. Using Select make list of City objects

        var modifiedCitiesQuery = from city in cities
            select $"{city[0].ToString().ToUpper()}{city.Substring(1)}";
        var modifiedCitiesExtension = cities.Select(city => $"{city[0].ToString().ToUpper()}{city.Substring(1)}");

        var citiesObjectsList = cities.Select(city => new City(city)).ToList();
        var orderedCities = citiesObjectsList.OrderBy(city => city.Name);
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


    public static void IntersectOperators()
    {
        var animals = new List<string> { "Zebra", "Elephant", "Cat", "Dog", "Lion", "Giraffe", "Parrot" };
        var domesticAnimals = new List<string> { "Cat", "Dog", "Parrot", "Horse" };
        var wildAnimals = new List<string> { "Lion", "Giraffe", "Parrot" };
        var animalsWithDuplicates = new List<string> { "Dog", "Cat", "Cat", "Dog", "Parrot", "Parrot", "Parrot" };
        var orderedAnimals = animals.OrderBy(animal => animal);
        var skippedAnimals = animals.TakeWhile(animal => animal.Length > 4).ToList();
        animals[1] = "Horse";
        Console.WriteLine(string.Join(' ', skippedAnimals));

        //if (skippedAnimals.Contains("Dog"))
        //{
        //    Console.WriteLine("Any animal starts will D!");
        //}

        //var emptyAnimals = new List<string>();
        //Console.WriteLine(string.Join(' ', emptyAnimals.FirstOrDefault()));
        //Console.WriteLine(string.Join(' ', emptyAnimals.First()));


        //+var wildAnimals = animals.Except(domesticAnimals);
        //+var interlocatedAnimals = domesticAnimals.Intersect(wildAnimals);
        //+var uniqueAnimals = animalsWithDuplicates.Distinct();
        //+var animalsUnion = animals.Union(domesticAnimals);
        //+var concatAnimals = animals.Concat(domesticAnimals);

        //Console.WriteLine(string.Join(' ', animalsUnion));
    }

}
