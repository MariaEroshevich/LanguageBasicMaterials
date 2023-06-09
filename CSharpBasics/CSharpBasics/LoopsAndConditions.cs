namespace CSharpBasics
{
    public class LoopsAndConditions
    {
        public void IfElseConditions(int grade)
        {
            if (grade >= 0 && grade <= 10)
            {
                if ((grade == 4 || grade == 5 || grade == 6) && specailCaracter == "+")
                {
                    Console.WriteLine("Exam passed satisfactory!");
                }
                else if (grade == 7 || grade == 8)
                {
                    Console.WriteLine("Exam passed good!");
                }
                else if (grade == 9 || grade == 10)
                {
                    Console.WriteLine("Exam passed excellent!");
                }
                else
                {
                    Console.WriteLine("Exam failed!");
                }
            }
        }

        public void Switch(int grade)
        {
            switch (grade)
            {
                case 4:
                    Console.WriteLine("Exam passed satisfactory!");
                    break;
                case 7:
                    Console.WriteLine("Exam passed good!");
                    break;
                case 10:
                    Console.WriteLine("Exam passed excellent!");
                    break;
                default:
                    Console.WriteLine("Exam failed!");
                    break;
            }
        }

        public void ForLoop()
        {
            // 1
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(j);
            }
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j < 5; j = j + 2)
                {
                    Console.WriteLine(i * j);
                }
            }

            // 2
            for (int j = 0; j < 5; j++)
            {
                if (j == 0)
                {
                    Console.WriteLine(j);
                    continue;
                }
                Console.WriteLine(j);
            }
        }

        public void WhileLoop()
        {
            // while loop
            int i = 0;

            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // do-while loop
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public void ForEach()
        {
            int[] massive = new int[2] { 1, 2 };

            foreach (var a in massive)
            {
                Console.WriteLine(a);
            }
        }
    }
}
