namespace PrimeMultiplicationTable
{
    using System;
    using System.Collections.Generic;

    public class PrimeNumbersGenerator : IPrimeNumbersGenerator
    {
        public List<int> GeneratePrimes(int length)
        {
            int count = 0;
            int primeCount = 0;
            double inp = Math.Pow(length, 2);

            var primes = new List<int>();
            primes.Add(0);

            for (int i = 1; i <= inp; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j != 0)
                    {
                        count += 1;
                    }
                }
                if (count == (i - 2))
                {
                    if (primeCount == length)
                    {
                        break;
                    }
                    primes.Add(i);
                    primeCount++;
                }

                count = 0;
            }

            return primes;
        }
    }
}
