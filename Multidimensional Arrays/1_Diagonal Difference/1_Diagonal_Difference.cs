using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            var firstDiagonal = 0;

            for (int i = 0; i < size; i++)
            {
                firstDiagonal += matrix[i, i];
            }

            var secondDiagonal = 0;
            for (int i = size - 1; i >= 0; i--)
            {
                secondDiagonal += matrix[size - 1 - i, i];
            }

            var difference = Math.Abs(firstDiagonal - secondDiagonal);

            Console.WriteLine(difference);
        }
    }
}
