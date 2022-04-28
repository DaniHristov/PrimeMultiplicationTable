using NUnit.Framework;
using System.Collections.Generic;

namespace PrimeMultiplicationTable.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void PrimeNumbersGeneratorShouldGenerateCorrectNumbers()
        {
            var primeNumberGenerator = new PrimeNumbersGenerator();
            var numbersQuantity = 5;

            var expectedPrimesList = new List<int> { 0, 2, 3, 5, 7, 11 };
            var primes = primeNumberGenerator.GeneratePrimes(numbersQuantity);

            Assert.AreEqual(expectedPrimesList, primes);
        }

        [Test]
        public void PrimeNumbersGeneratorShouldNotBeNull()
        {
            var primeNumberGenerator = new PrimeNumbersGenerator();

            Assert.IsNotNull(primeNumberGenerator);
        }


    }
}