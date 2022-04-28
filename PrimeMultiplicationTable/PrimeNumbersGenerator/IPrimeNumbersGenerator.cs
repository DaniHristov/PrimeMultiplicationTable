namespace PrimeMultiplicationTable
{
    using System.Collections.Generic;

    public interface IPrimeNumbersGenerator
    {
        List<int> GeneratePrimes(int length);
    }
}