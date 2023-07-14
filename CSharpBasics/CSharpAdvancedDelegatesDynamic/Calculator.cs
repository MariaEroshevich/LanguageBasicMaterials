namespace CSharpAdvancedDelegatesDynamic
{
    public static class Calculator
    {
        public static int Add(this int x, int y) => x + y;

        public static int Subtract(this int x, int y) => x - y;

        public static int Multiply(this int x, int y) => x * y;

        public static int Divide(this int x, int y) => x / y;
    }
}
