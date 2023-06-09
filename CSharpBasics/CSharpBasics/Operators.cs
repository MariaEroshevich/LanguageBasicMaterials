namespace CSharpBasics
{
    public class Operators
    {
        #region Бинарные операторы

        #region Арифметические операторы

        /*
        + Сложение
        - Вычитание
        * Умножение
        / Деление
        % Деление по модулю
        */

        public void MathOperators()
        {
            double a = 2;
            int b = 5;
            int c = 6;

            c += 5;

            var result = (a + b) + c * c;

            var resultSum = a + b;
            var resultDif = a - b;
            var resultMul = a * b;

            double resultDiv = a / b; // 0.4
            Console.WriteLine(resultDiv);
            Console.ReadKey();
        }

        #endregion

        #region Операторы сравнения

        /*
        == Равно
        != Не равно
        > Больше
        < Меньше
        >= Больше или равно
        <= Меньше или равно
        */

        public void ComparisonOperators()
        {
            int a = 5;
            int b = 5;

            bool areEqual = a != b;
            Console.WriteLine(areEqual);
        }
        
        #endregion

        #region Логические операторы

        /*
        Логические операторы

        && Сокращенное И
        || Сокращенное ИЛИ
        &  И
        |  ИЛИ
        !  НЕ
        ^  Логическое исключение ИЛИ
        */

        public void LogicOperators()
        {
            var a = true;
            var b = !a;
            Console.WriteLine(b);

            bool hasGun = false;
            bool hasHeals = true;
            Console.WriteLine($"Is character fully equipped? {hasGun && hasHeals}");
            Console.WriteLine($"Is character fully equipped? {hasGun & hasHeals}");

            Console.WriteLine($"True ^ True => {true ^ true}");
            Console.WriteLine($"True ^ False => {true ^ false}");
            Console.WriteLine($"False ^ True => {false ^ true}");
            Console.WriteLine($"False ^ False => {false ^ false}");
        }

        #endregion

        #endregion

        #region Унарные операторы

        /*
        ++a Инкремент префиксный
        a++ Инкремент постфиксный
        --a Декремент префиксный
        a-- Декремент постфиксный
        */

        public void UnaryOperators()
        {
            int a = 0;

            a = a - 1; // == a--;

            a--;
            a--;
            a--;

            a = 1;
            // постфикс
            a = a++ * a;
            // a = a * a = 1;
            // a++ => 1 + 1

            // префикс
            a = ++a * a;
            // a = a++; => 2
            // a * a => 2 * 2

            Console.WriteLine(a);
        }

        #endregion

        #region Приведение типов

        public void Cast()
        {
            byte a = 4;

            int b = a + 70;

            Console.WriteLine(b);

            //неявные преобразования -> меньший в больший

            double a = 4; // 0000100

            double b = a; // 0000000000100

            //явные преобразования -> больший в меньший

            int c = 4;
            int d = 6;
            byte e = (byte)(c + d);

            int a = 33;
            int b = 800;
            int c = (a + b);
            Console.Write(c);

            //void Sum(int a, int b)
            //{
            //}

            //Sum((int)a, (int)b);
        }

        public void CastWithConvert()
        {
            // преобразование со вспомогательными классами

            short a = 15;
            int b = Convert.ToInt32(a);
        }

        public void BoxingUnboxing()
        {
            short a = 15;
            object b = a;
            int c = (int)b;
        }

        #endregion
    }
}
