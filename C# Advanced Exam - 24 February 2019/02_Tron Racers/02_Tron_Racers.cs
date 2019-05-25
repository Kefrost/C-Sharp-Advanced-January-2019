using System;
using System.Linq;
namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new char[size][];
            

            for (int line = 0; line < matrix.Length; line++)
            {
                var input = Console.ReadLine().ToCharArray();
                matrix[line] = input;
                
            }
            int indexOfFirst = 0;
            int rowOfFirst = 0;
            int indexOfSecond = 0;
            int rowOfSecond = 0;
            bool isDead = false;
            for (int line = 0; line < matrix.Length; line++)
            {
                if (matrix[line].Contains('f'))
                {
                    indexOfFirst = Array.IndexOf(matrix[line], 'f');
                    rowOfFirst = line;
                }
                if (matrix[line].Contains('s'))
                {
                    indexOfSecond = Array.IndexOf(matrix[line], 's');
                    rowOfSecond = line;
                }
            }
            while (true)
            {
                var command = Console.ReadLine().Split();
                var commandFirst = command[0];
                var commandSecond = command[1];

                
                if (commandFirst == "up")
                {
                    if ( rowOfFirst - 1 < 0)
                    {
                        matrix[matrix.Length - 1][indexOfFirst] = 'f';
                        rowOfFirst = matrix.Length - 1;

                    }
                    else if (matrix[rowOfFirst - 1][indexOfFirst] == 's')
                    {
                        matrix[rowOfFirst - 1][indexOfFirst] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[rowOfFirst - 1][indexOfFirst] = 'f';
                        rowOfFirst = rowOfFirst - 1;
                    }
                }
                else if (commandFirst == "down")
                {
                    if (rowOfFirst + 1 > size - 1)
                    {
                        matrix[0][indexOfFirst] = 'f';
                        rowOfFirst = 0;

                    }
                    else if (matrix[rowOfFirst + 1][indexOfFirst] == 's')
                    {
                        matrix[rowOfFirst + 1][indexOfFirst] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[rowOfFirst + 1][indexOfFirst] = 'f';
                        rowOfFirst = rowOfFirst + 1;
                    }
                }
                else if (commandFirst == "left")
                {
                    if (indexOfFirst - 1 < 0)
                    {
                        matrix[rowOfFirst][size - 1] = 'f';
                        indexOfFirst = size - 1;
                    }
                    else if (matrix[rowOfFirst][indexOfFirst - 1] == 's')
                    {
                        matrix[rowOfFirst][indexOfFirst - 1] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[rowOfFirst][indexOfFirst - 1] = 'f';
                        indexOfFirst = indexOfFirst - 1;
                    }
                }
                else if (commandFirst == "right")
                {
                    if (indexOfFirst + 1 > size - 1)
                    {
                        matrix[rowOfFirst][0] = 'f';
                        indexOfFirst = 0;
                    }
                    else if (matrix[rowOfFirst][indexOfFirst + 1] == 's')
                    {
                        matrix[rowOfFirst][indexOfFirst + 1] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[rowOfFirst][indexOfFirst + 1] = 'f';
                        indexOfFirst = indexOfFirst + 1;
                    }
                }

                if (commandSecond == "up")
                {
                    if (rowOfFirst - 1 < 0)
                    {
                        matrix[matrix.Length - 1][indexOfSecond] = 's';
                        rowOfSecond = matrix.Length - 1;
                    }
                    else if (matrix[rowOfSecond - 1][indexOfSecond] == 'f')
                    {
                        matrix[rowOfSecond - 1][indexOfSecond] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[rowOfSecond - 1][indexOfSecond] = 's';
                        rowOfSecond = rowOfSecond - 1;
                    }
                }
                else if (commandSecond == "down")
                {
                    if (rowOfSecond + 1 > size - 1)
                    {
                        matrix[0][indexOfSecond] = 's';
                        rowOfSecond = 0;
                    }
                   else if (matrix[rowOfSecond + 1][indexOfSecond] == 'f')
                    {
                        matrix[rowOfSecond + 1][indexOfSecond] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[rowOfSecond + 1][indexOfSecond] = 's';
                        rowOfSecond = rowOfSecond + 1;
                    }
                }
                else if (commandSecond == "left")
                {
                    if (indexOfSecond - 1 < 0)
                    {
                        matrix[rowOfSecond][size - 1] = 's';
                        indexOfSecond = size - 1;
                    }
                    else if (matrix[rowOfSecond][indexOfSecond - 1] == 'f')
                    {
                        matrix[rowOfSecond][indexOfSecond - 1] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[rowOfSecond][indexOfSecond - 1] = 's';
                        indexOfSecond = indexOfSecond - 1;
                    }
                }
                else if (commandSecond == "right")
                {
                    if (indexOfSecond + 1 > size - 1)
                    {
                        matrix[rowOfSecond][0] = 's';
                        indexOfSecond = 0;
                    }
                    else if (matrix[rowOfSecond][indexOfSecond + 1] == 'f')
                    {
                        matrix[rowOfSecond][indexOfSecond + 1] = 'x';
                        break;
                    }
                    else
                    {
                        matrix[rowOfSecond][indexOfSecond + 1] = 's';
                        indexOfSecond = indexOfSecond + 1;
                    }
                }
                
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(row);
            }
            
        }
    }
}
