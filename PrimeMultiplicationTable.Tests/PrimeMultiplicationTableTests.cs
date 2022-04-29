using NUnit.Framework;

namespace PrimeMultiplicationTable.Tests
{
    [TestFixture]
    public class PrimeMultiplicationTableTests
    {
        private PrimeMultiplicationTable primeMultiplicationTable;
        private PrimeNumbersGenerator primeNumbersGenerator;

        [SetUp]
        public void Setup()
        {
            primeMultiplicationTable = new PrimeMultiplicationTable();
            primeNumbersGenerator = new PrimeNumbersGenerator();
        }

        [Test]
        public void PrimeMultiplicationTableShouldNotBeNull()
        {
            Assert.IsNotNull(primeMultiplicationTable);
        }

        [Test]
        [TestCase(3)]
        [TestCase(7)]
        [TestCase(9)]
        [TestCase(5)]
        public void PrimeMultiplicationTableShouldReturnCorrectValues(int n)
        {
            var primes = primeNumbersGenerator.GeneratePrimes(n);
            var matrix = primeMultiplicationTable.GenerateMultiplicationTable(primes, n);

            var firstNumber = matrix[1, 1];
            var secondNumber = matrix[2, 2];
            var thirdNumber = matrix[3, 3];

            var firstExpected = 4;
            var secondExpected = 9;
            var thirdExpected = 25;

            Assert.AreEqual(firstExpected, firstNumber);
            Assert.AreEqual(secondExpected, secondNumber);
            Assert.AreEqual(thirdExpected, thirdNumber);
        }
    }
}
