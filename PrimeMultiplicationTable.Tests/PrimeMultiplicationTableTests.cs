using NUnit.Framework;
using System.Collections.Generic;

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
            var primes = primeNumbersGenerator
                .GeneratePrimes(n);

            var matrix = primeMultiplicationTable
                .GenerateMultiplicationTable(primes, n);

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

        [Test]
        public void PrimeMultiplicationTableShouldReturnCorrectTable()
        {
            var table = primeMultiplicationTable
                .GenerateMultiplicationTable(primeNumbersGenerator.GeneratePrimes(5),5);

            int[,] expectedTable = new int[,]
            {
                { 0, 2, 3, 5, 7, 11 },
                { 2, 4, 6, 10, 14, 22 },
                { 3, 6, 9, 15, 21, 33 },
                { 5, 10, 15, 25, 35, 55 },
                { 7, 14, 21, 35, 49, 77 },
                { 11, 22, 33, 55, 77, 121 },
            };

            Assert.AreEqual(expectedTable, table);

        }
    }
}
