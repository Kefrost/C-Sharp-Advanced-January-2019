using System;
using System.Collections.Generic;
using System.Linq;
namespace FindEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string evenOrOdd = Console.ReadLine();

            Predicate<int> evenOrOdds;
            var listOnNums = new List<int>();
            for (int i = input[0]; i <= input[1]; i++)
            {
                listOnNums.Add(i);
            }
            if (evenOrOdd == "even")
            {
                evenOrOdds = x => x % 2 == 0;
            }
            else
            {
                evenOrOdds = x => x % 2 != 0;
            }
            Console.Write(string.Join(" ", listOnNums.Where(x => evenOrOdds(x))));
            Console.WriteLine();
        }
    }
}
