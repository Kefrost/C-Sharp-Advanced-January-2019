using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.Excel
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());

            string[][] matrix = new string[numOfRows][];
            for (int i = 0; i < numOfRows; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                matrix[i] = input;
            }

            string[] command = Console.ReadLine().Split();

            if (command[0] == "hide")
            {
                var headerToHide = command[1];
                var indexOfHeader = Array.IndexOf(matrix[0], headerToHide);
                
                for (int rows = 0; rows < matrix.Length; rows++)
                {
                    var list = new List<string>(matrix[rows]);
                    list.RemoveAt(indexOfHeader);
                    Console.WriteLine(string.Join(" | ", list));
                }
            }
           
            else if (command[0] == "sort")
            {
                var headerToSort = command[1];
                var indexOfHeader = Array.IndexOf(matrix[0], headerToSort);
                string[] header = matrix[0];
                Console.WriteLine(string.Join(" | ", header));

                matrix = matrix.OrderBy(x => x[indexOfHeader]).ToArray();

                foreach (var row in matrix)
                {
                    if (row != header)
                    {
                        Console.WriteLine(string.Join(" | ", row));
                    }
                }
            }
            else if (command[0] == "filter")
            {
                string headerData = command[1];
                string value = command[2];
                var indexOfHeader = Array.IndexOf(matrix[0], headerData);
                string[] header = matrix[0];

                Console.WriteLine(string.Join(" | ", header));

                for (int row = 0; row < matrix.Length; row++)
                {
                    var list = new List<string>();
                    if (matrix[row][indexOfHeader] == value)
                    {
                        list.AddRange(matrix[row]);
                        Console.WriteLine(string.Join(" | ", list));
                    }
                }
                
            }
        }
    }
}
