Console.WriteLine("Enter student grade:");
string valueFromConsole = Console.ReadLine();
var grade = int.Parse(valueFromConsole.Substring(0, 1));
//if (grade >= 0 && grade <= 10)
//{
//    if ((grade == 4 || grade == 5 || grade == 6) && specailCaracter == "+")
//    {
//        Console.WriteLine("Exam passed satisfactory!");
//    }
//    else if (grade == 7 || grade == 8)
//    {
//        Console.WriteLine("Exam passed good!");
//    }
//    else if (grade == 9 || grade == 10)
//    {
//        Console.WriteLine("Exam passed excellent!");
//    }
//    else
//    {
//        Console.WriteLine("Exam failed!");
//    }
//}


//switch (grade)
//{
//    case 4:
//        Console.WriteLine("Exam passed satisfactory!");
//        break;
//    case 7:
//        Console.WriteLine("Exam passed good!");
//        break;
//    case 10:
//        Console.WriteLine("Exam passed excellent!");
//        break;
//    default:
//        Console.WriteLine("Exam failed!");
//        break;
//}

//for (int j = 0; j < 5; j++)
//{
//    Console.WriteLine(j);
//}
//for (int i = 0; i <= 10; i++)
//{
//    for (int j = 0; j < 5; j = j + 2)
//    {
//        Console.WriteLine(i * j);
//    }
//}

//int i = 0;

//while (i < 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int i = 0;

//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i < 5);

//int[] massive = new int[2] { 1, 2};

//foreach (var a in massive)
//{
//    Console.WriteLine(a);
//}

//for (int j = 0; j < 5; j++)
//{
//    if (j == 0)
//    {
//        Console.WriteLine(j);
//        continue;
//    }
//    Console.WriteLine(j);
//}

//if (grade > 4)
//{
//    Console.WriteLine("Exam passed!");
//}
//else
//{
//    Console.WriteLine("Exam failed!");
//}

Console.WriteLine(grade > 4 ? "Exam passed!" : "Exam failed!");