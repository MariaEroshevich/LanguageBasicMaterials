using MSTestExample;

namespace NUnitTestsExample
{
    public class Tests
    {
        private SumNumbers _sumNumbers;

        [OneTimeSetUp]
        public void ClassInitialize()
        {
            Console.WriteLine("Class init");
        }

        [SetUp]
        public void TestInitialize()
        {
            Console.WriteLine("Test init");
            _sumNumbers = new SumNumbers();
        }

        [Test]
        public void TestMethod1()
        {
            string hello = "Hello test";

            Assert.AreEqual("Hello test", hello, $"{hello} equals to \"Hello test\"");
        }

        [TestCase(4, 4, 8)]
        [TestCase(0, 4.3, 4.3)]
        [TestCase(-5, -6, -11)]
        public void SumTest(double firstNumber, double secondNumber, double expectedSum)
        {
            var actualSum = _sumNumbers.Sum(firstNumber, secondNumber);

            Assert.AreNotEqual(expectedSum, actualSum);
        }

        [TestCase(4, 0)]
        public void DivideTest(double firstNumber, double secondNumber)
        {
            Assert.Throws<DivideByZeroException>(() => _sumNumbers.Divide(firstNumber, secondNumber));
        }

        [Test]
        [TestCase(5, 4, 8)]
        [TestCase(0, 4.3, 4.3)]
        [TestCase(-5, -6, -11)]
        public void AAAExample(double firstNumber, double secondNumber, double expectedSum)
        {
            //Act
            var actualSum = _sumNumbers.Sum(firstNumber, secondNumber);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(55, 55);
                Assert.AreEqual(expectedSum, actualSum);
            });
        }

        [TearDown]
        public void TestCleanup()
        {
            Console.WriteLine("Test cleanup");
        }

        [OneTimeTearDown]
        public void ClassCleanup()
        {
            Console.WriteLine("Test cleanup");
        }
    }
}