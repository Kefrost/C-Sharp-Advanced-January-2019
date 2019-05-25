using System;
using System.Linq;
using System.Collections.Generic;

namespace Periodic_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                    set.Add(item);
                }
            }
            var sorted = set.OrderBy(x => x).ToList();
            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
