using NUnit.Framework;
using System.Collections.Generic;

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
            var primes = primeNumbersGenerator.GeneratePrimes(numbersQuantity);

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
        public void PrimeNumbersGeneratorShouldNotBeNull()
        {
            Assert.IsNotNull(primeNumbersGenerator);
        }
    }
}