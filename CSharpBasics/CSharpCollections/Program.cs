//int[] massive = new int[5];
//massive[0] = 1;
//massive[1] = 2;
//massive[2] = 3;
//massive[3] = 4;
//massive[4] = 5;

//foreach (int index in massive)
//{
//    Console.WriteLine(index);
//}

//int[] massive2 = new int[] { 1, 2, 3, 4, 5, 6 };

//for (int i = 1; i <= massive2.Length - 1; i++)
//{
//    Console.WriteLine(massive2[i]);
//}

//Console.WriteLine(massive2[^1]);


//foreach (int index in massive2)
//{
//    Console.WriteLine(index);
//}

//string[] stringMassive = { "First Name", "Last Name", "Age" };

//foreach (string index in stringMassive)
//{
//    Console.WriteLine(index);
//}


//Многомерный массив
//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
////foreach (int i in numbers) 
////{
////    Console.WriteLine(i);
////}

//int row = numbers.GetUpperBound(0) + 1;
////Console.WriteLine(row);

//int columns = numbers.Length / row;
////Console.WriteLine(columns);

//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < columns; j ++)
//    {
//        Console.WriteLine(numbers[i, j]);
//    }
//}

//Массив массивов
//int[][] massive3 = new int[5][];
//massive3[0] = new int[2];
//massive3[1] = new int[2];
//massive3[2] = new int[2];
//massive3[3] = new int[3];
//massive3[4] = new int[4];

//for (int i = 0; i < massive3.Length; i++)
//{
//    for (int j = 0; j < massive3[i].Length; j++)
//    {
//        massive3[i][j] = j;
//        Console.WriteLine(massive3[i][j]);

//    }
//}

//class Array

using System.Collections;

Array massive4 = Array.CreateInstance(typeof(string), 3);
massive4.SetValue("First Name", 0);
massive4.SetValue("Last Name", 1);
massive4.SetValue("Age", 2);

//foreach (var massive in massive4)
//{
//    Console.WriteLine(massive);
//}

//Console.WriteLine(massive4.GetValue(2));

//var people = new string[] { "Tom", "Sten", "Stiven", "Bill", "Sten" };
//Array.Sort(people);
//var index = Array.BinarySearch(people, "Sten");
//Console.WriteLine(index);

//var index1 = Array.IndexOf(people, "Sten");
//Console.WriteLine(index1);

//string[] newPeople = new string[8];
//Array.Copy(people, 0, newPeople, 0, 3);
//newPeople.SetValue("Tom", 3);
//newPeople.SetValue("Ban", 4);
//newPeople.SetValue("Bob", 5);
//newPeople.SetValue("Tomas", 6);
//newPeople.SetValue("Jhon", 7);

//Array.Reverse(newPeople);

//foreach (var person in newPeople)
//{
//    Console.WriteLine(person);
//}

//ArrayList arrayList = new ArrayList();
//arrayList.Add(5);
//arrayList.Add("Tom");
//arrayList.Add('C');
//arrayList.Add(12.0);
//arrayList.AddRange(massive4);

//arrayList.Insert(4, "Bob");

////foreach(var i in arrayList)
////{
////    Console.WriteLine(i);
////}

//for (int i = 0; i <= arrayList.Count - 1; i++ )
//{
//    Console.WriteLine(arrayList[i]);
//}

//arrayList.Remove("Bob");

//for (int i = 0; i <= arrayList.Count - 1; i++)
//{
//    Console.WriteLine(arrayList[i]);
//}

//List<string> list = new List<string>() { "Jhon", "Mitch" };
//list.Add("Tom");
//list.Add("Bob");

//foreach (var s in list)
//{
//    Console.WriteLine(s);
//}

//Console.WriteLine(list.Count);

Dictionary<string, int> dictinary = new Dictionary<string, int>();
dictinary.Add("age", 25);
dictinary.Add("volume", 66);
dictinary.TryAdd("age", 33);

dictinary.TryGetValue("age", out int value);

Console.WriteLine(value);

//foreach (var s in dictinary)
//{
//    Console.WriteLine(s);
//}