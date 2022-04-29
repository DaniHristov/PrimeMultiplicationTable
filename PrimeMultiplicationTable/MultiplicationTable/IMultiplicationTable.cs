namespace PrimeMultiplicationTable
{
    using System.Collections.Generic;

    public interface IMultiplicationTable
    {
        public int[,] GenerateMultiplicationTable(List<int> numbers, int size);
    }
}