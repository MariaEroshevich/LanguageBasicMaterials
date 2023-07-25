namespace MSTestExample
{
    [TestClass]
    public class MSTestExampleTests
    {
        private SumNumbers _sumNumbers;

        [ClassInitialize]
        public void ClassInitialize()
        {
            Console.WriteLine("Class init");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("Test init");
            _sumNumbers = new SumNumbers();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string hello = "Hello test";

            Assert.AreEqual("Hello test", hello, $"{hello} equals to \"Hello test\"");
        }

        //[TestMethod]
        //[DataRow(4, 4, 8)]
        //[DataRow(0, 4.3, 4.3)]
        //[DataRow(-5,-6, -11)]
        //public void SumTest(double firstNumber, double secondNumber, double expectedSum)
        //{
        //    var actualSum = _sumNumbers.Sum(firstNumber, secondNumber);

        //    Assert.AreNotEqual(expectedSum, actualSum);
        //}

        //[TestMethod]
        //[DataRow(4, 0)]
        //public void DivideTest(double firstNumber, double secondNumber)
        //{
        //    Assert.ThrowsException<DivideByZeroException>(() => _sumNumbers.Divide(firstNumber, secondNumber));
        //}

        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("Test cleanup");
        }

        [ClassCleanup]
        public void ClassCleanup()
        {
            Console.WriteLine("Test cleanup");
        }
    }
}