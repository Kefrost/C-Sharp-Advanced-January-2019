using System;
using System.Linq;
using System.Collections.Generic;
namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var evenNums = nums.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            var oddNums = nums.Where(x => x % 2 != 0).OrderBy(x => x).ToList();

            Console.Write(string.Join (" ", evenNums));
            Console.Write($" {string.Join (" ", oddNums)}");
            Console.WriteLine();
        }
    }
}
