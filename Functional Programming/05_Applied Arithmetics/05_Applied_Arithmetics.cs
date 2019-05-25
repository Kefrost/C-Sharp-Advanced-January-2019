using System;
using System.Linq;
using System.Collections.Generic;
namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                Func<int, int> manipulate;
                if (command == "add")
                {
                    manipulate = x => x + 1;
                }
                else if (command == "subtract")
                {
                    manipulate = x => x - 1;
                }
                else if (command == "multiply")
                {
                    manipulate = x => x * 2;
                }
                else
                {
                    manipulate = x => x;
                }

                listOfNums = listOfNums.Select(manipulate).ToList();

                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", listOfNums));
                }
                command = Console.ReadLine();
            }
        }
    }
}
