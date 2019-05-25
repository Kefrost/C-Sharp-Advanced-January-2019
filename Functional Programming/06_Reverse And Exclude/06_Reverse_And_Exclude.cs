using System;
using System.Linq;
using System.Collections.Generic;
namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var collectionOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divide = int.Parse(Console.ReadLine());

            Func<int, bool> divideFunc = x => x % divide != 0;

            collectionOfNums.Reverse();

            Console.WriteLine(string.Join(" ", collectionOfNums.Where(divideFunc)));
        }
    }
}
