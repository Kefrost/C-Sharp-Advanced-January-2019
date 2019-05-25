using System;
using System.Linq;

namespace _033
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int rows = int.Parse(Console.ReadLine());

            var matrix = new char[rows][];

            var isAbducted = false;

            for (int i = 0; i < rows; i++)
            {
                var inputRows = Console.ReadLine().ToCharArray();

                matrix[i] = inputRows;
            }

            int indexOfPlayer = 0;
            int rowOfPlayer = 0;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i].Contains('P'))
                {
                    indexOfPlayer = Array.IndexOf(matrix[i],'P');
                    rowOfPlayer = i;
                }

            }

            var input = Console.ReadLine().Split();

            while (energy > 0)
            {

                matrix[int.Parse(input[1])][int.Parse(input[2])] = 'S';

                if (input[0] == "up")
                {
                    energy--;

                    if (rowOfPlayer != 0)
                    {
                        if (matrix[rowOfPlayer - 1][indexOfPlayer] == 'H')
                        {
                            matrix[rowOfPlayer - 1][indexOfPlayer] = '-';
                            matrix[rowOfPlayer][indexOfPlayer] = '-';

                            isAbducted = true;
                            break;
                        }
                        else if (matrix[rowOfPlayer - 1][indexOfPlayer] == 'S')
                        {
                            energy -= 2;
                            if (energy<= 0)
                            {
                                matrix[rowOfPlayer - 1][indexOfPlayer] = 'X';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                rowOfPlayer = rowOfPlayer - 1;

                                break;

                            }
                            else
                            {
                                matrix[rowOfPlayer - 1][indexOfPlayer] = 'P';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                rowOfPlayer = rowOfPlayer - 1;


                            }
                        }
                        else
                        {
                            if (energy <= 0)
                            {
                                matrix[rowOfPlayer - 1][indexOfPlayer] = 'X';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                rowOfPlayer = rowOfPlayer - 1;

                                break;

                            }
                            else
                            {
                                matrix[rowOfPlayer - 1][indexOfPlayer] = 'P';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                rowOfPlayer = rowOfPlayer - 1;


                            }


                        }
                    }

                    if (energy <= 0)
                    {
                        matrix[rowOfPlayer][indexOfPlayer] = 'X';
                        break;
                    }
                    
                    
                }

                else if (input[0] == "down")
                {
                    energy--;

                    if (rowOfPlayer < rows - 1)
                    {
                        if (matrix[rowOfPlayer + 1][indexOfPlayer] == 'H')
                        {
                            matrix[rowOfPlayer + 1][indexOfPlayer] = '-';
                            matrix[rowOfPlayer][indexOfPlayer] = '-';

                            isAbducted = true;
                            break;
                        }
                        else if (matrix[rowOfPlayer + 1][indexOfPlayer] == 'S')
                        {
                            energy -= 2;
                            rowOfPlayer++;

                            if (energy <= 0)
                            {
                                matrix[rowOfPlayer + 1][indexOfPlayer] = 'X';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                rowOfPlayer = rowOfPlayer + 1;

                                break;
                            }
                            else
                            {
                                matrix[rowOfPlayer + 1][indexOfPlayer] = 'P';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                rowOfPlayer = rowOfPlayer + 1;


                            }
                        }
                        else
                        {
                            if (energy <= 0)
                            {
                                matrix[rowOfPlayer + 1][indexOfPlayer] = 'X';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                rowOfPlayer = rowOfPlayer + 1;

                                break;
                            }
                            else
                            {
                                matrix[rowOfPlayer + 1][indexOfPlayer] = 'P';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                rowOfPlayer = rowOfPlayer + 1;


                            }


                        }
                    }

                    if (energy <= 0)
                    {
                        matrix[rowOfPlayer][indexOfPlayer] = 'X';
                        break;
                    }


                }

                else if (input[0] == "left")
                {
                    energy--;

                    if (indexOfPlayer > 0)
                    {
                        if (matrix[rowOfPlayer][indexOfPlayer - 1] == 'H')
                        {
                            matrix[rowOfPlayer][indexOfPlayer - 1] = '-';
                            matrix[rowOfPlayer][indexOfPlayer] = '-';

                            isAbducted = true;
                            break;
                        }
                        else if (matrix[rowOfPlayer][indexOfPlayer - 1] == 'S')
                        {
                            energy -= 2;
                            indexOfPlayer--;

                            if (energy <= 0)
                            {
                                matrix[rowOfPlayer][indexOfPlayer - 1] = 'X';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                indexOfPlayer = indexOfPlayer - 1;

                                break;

                            }
                            else
                            {
                                matrix[rowOfPlayer][indexOfPlayer - 1] = 'P';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                indexOfPlayer = indexOfPlayer - 1;


                            }
                        }
                        else
                        {
                            if (energy <= 0)
                            {
                                matrix[rowOfPlayer][indexOfPlayer - 1] = 'X';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                indexOfPlayer = indexOfPlayer - 1;

                                break;

                            }
                            else
                            {
                                matrix[rowOfPlayer][indexOfPlayer - 1] = 'P';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                indexOfPlayer = indexOfPlayer - 1;


                            }


                        }
                    }

                    if (energy <= 0)
                    {
                        matrix[rowOfPlayer][indexOfPlayer] = 'X';
                        break;
                    }


                }

                else if (input[0] == "right")
                {
                    energy--;

                    if (indexOfPlayer < matrix[rowOfPlayer].Length - 1)
                    {
                        if (matrix[rowOfPlayer][indexOfPlayer + 1] == 'H')
                        {
                            matrix[rowOfPlayer][indexOfPlayer + 1] = '-';
                            matrix[rowOfPlayer][indexOfPlayer] = '-';

                            isAbducted = true;
                            break;
                        }
                        else if (matrix[rowOfPlayer][indexOfPlayer + 1] == 'S')
                        {
                            energy -= 2;
                            indexOfPlayer++;
                            if (energy <= 0)
                            {
                                matrix[rowOfPlayer][indexOfPlayer + 1] = 'X';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                indexOfPlayer = indexOfPlayer + 1;

                                break;

                            }
                            else
                            {
                                matrix[rowOfPlayer][indexOfPlayer + 1] = 'P';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                indexOfPlayer = indexOfPlayer + 1;


                            }
                        }
                        else
                        {
                            if (energy <= 0)
                            {
                                matrix[rowOfPlayer][indexOfPlayer + 1] = 'X';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                indexOfPlayer = indexOfPlayer + 1;

                                break;

                            }
                            else
                            {
                                matrix[rowOfPlayer][indexOfPlayer + 1] = 'P';
                                matrix[rowOfPlayer][indexOfPlayer] = '-';
                                indexOfPlayer = indexOfPlayer + 1;


                            }


                        }
                    }

                    if (energy <= 0)
                    {
                        matrix[rowOfPlayer][indexOfPlayer] = 'X';
                        break;
                    }


                }

                input = Console.ReadLine().Split();
            }

            if (isAbducted)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}"); ;

                for (int i = 0; i < rows; i++)
                {
                    for (int l = 0; l < matrix[i].Length; l++)
                    {
                        Console.Write(matrix[i][l]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Paris died at {rowOfPlayer};{indexOfPlayer}.");
                for (int i = 0; i < rows; i++)
                {
                    for (int l = 0; l < matrix[i].Length; l++)
                    {
                        Console.Write(matrix[i][l]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
