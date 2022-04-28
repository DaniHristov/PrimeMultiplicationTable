namespace PrimeMultiplicationTable
{

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    using static Constants;
    public class PrimeMultiplicationTable : IMultiplicationTable
    {
        public void GenerateMultiplicationTable(List<int> numbers, int size)
        {
            int[,] matrix = new int[size + 1, size + 1];
            var sb = new StringBuilder();
            SaveTableAsHTML(numbers, size, matrix, sb);
        }

        private static void SaveTableAsHTML(List<int> numbers, int size, int[,] matrix, StringBuilder sb)
        {
            sb.Append("<h1 align=center>Prime Multiplication Table</h1>");
            sb.Append("<table cellspacing=1 bgcolor=#000000 align=center>");
            sb.Append($"<h4 align=center>With the first {size} prime numbers:</h4>");

            FillTable(numbers, matrix, sb);

            sb.Append("</table>");
            File.WriteAllText(dir, sb.ToString());
            Console.WriteLine($"Your table was successfully saved in {dir}.");
            Console.WriteLine();
            Console.WriteLine("Thanks for using our application!");
        }

        private static void FillTable(List<int> numbers, int[,] matrix, StringBuilder sb)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sb.Append("<tr bgcolor=#ffffff>");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == 0)
                    {
                        matrix[row, col] = numbers[col];
                    }
                    else if (col == 0)
                    {
                        matrix[row, col] = numbers[col + row];
                    }
                    else
                    {
                        matrix[row, col] = matrix[row, 0] * numbers[col];
                    }

                    sb.Append($"<td align=center> {matrix[row, col]} </td>");
                }
                sb.Append("</tr>");
            }
        }
    }
}
