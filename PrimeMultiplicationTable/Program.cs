using System;
using System.Threading;

namespace PrimeMultiplicationTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = ParseInput();

            var primeGenerator = new PrimeNumbersGenerator();
            var primes = primeGenerator.GeneratePrimes(n);

            var multiplicationTable = new PrimeMultiplicationTable();
            multiplicationTable.GenerateMultiplicationTable(primes, n);
        }

        private static int ParseInput()
        {   
            Console.WriteLine("Input a number bigger than 1 to find Prime numbers please...");
            var n = int.Parse(Console.ReadLine());

            while (n<2)
            {
                Console.WriteLine("Please input a number bigger than 1 ...");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Generating HTML multiplication table with the first {n} numbers...");
            Console.WriteLine();
            Thread.Sleep(1000);

            return n;
        }
    }
}
