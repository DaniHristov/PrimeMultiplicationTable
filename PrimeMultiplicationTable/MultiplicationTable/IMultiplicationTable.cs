namespace PrimeMultiplicationTable
{
    using System.Collections.Generic;

    public interface IMultiplicationTable
    {
        public void GenerateMultiplicationTable(List<int> numbers, int size);
    }
}