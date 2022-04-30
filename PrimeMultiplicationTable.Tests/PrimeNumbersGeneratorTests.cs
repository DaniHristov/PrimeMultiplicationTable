using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace PrimeMultiplicationTable.Tests
{
    [TestFixture]
    public class PrimeNumbersGeneratorTests
    {
        private PrimeNumbersGenerator primeNumbersGenerator;

        [SetUp]
        public void Setup()
        {
            primeNumbersGenerator = new PrimeNumbersGenerator();
        }

        [Test]
        public void PrimeNumbersGeneratorShouldGenerateCorrectNumbers()
        {
            var numbersQuantity = 5;

            var expectedPrimesList = new List<int> { 0, 2, 3, 5, 7, 11 };
            var primes = primeNumbersGenerator
                .GeneratePrimes(numbersQuantity);

            Assert.AreEqual(expectedPrimesList, primes);
        }

        [Test]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(6)]
        public void GeneratedPrimesListShouldNotBeNull(int n)
        {
            var primesList = primeNumbersGenerator.GeneratePrimes(n);

            Assert.IsNotEmpty(primesList);
        }

        [Test]
        [TestCase(6)]
        [TestCase(4)]
        [TestCase(3)]
        public void GeneratePrimesListShouldBeWithCorrectCount(int n)
        {
            var primesList = primeNumbersGenerator.GeneratePrimes(n);

            var actual = primesList.Count();
            var expected = n + 1;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PrimeNumbersGeneratorShouldNotBeNull()
        {
            Assert.IsNotNull(primeNumbersGenerator);
        }
    }
}