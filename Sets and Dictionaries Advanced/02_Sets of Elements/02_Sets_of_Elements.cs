using System;
using System.Collections.Generic;
using System.Linq;
namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lenghtFirst = input[0];
            int lenghtSecond = input[1];
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var repeatingSet = new HashSet<int>();
            for (int i = 0; i < lenghtFirst; i++)
            {
                int element = int.Parse(Console.ReadLine());
                firstSet.Add(element);
            }
            for (int i = 0; i < lenghtSecond; i++)
            {
                int element = int.Parse(Console.ReadLine());
                secondSet.Add(element);
            }
            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    repeatingSet.Add(item);
                }
            }
            foreach (var item in repeatingSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
