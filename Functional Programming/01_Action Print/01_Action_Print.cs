using System;
using System.Linq;
using System.Collections.Generic;
namespace func
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = Console.WriteLine;
            var input = Console.ReadLine().Split().ToList();
            foreach (var item in input)
            {
                print(item);
            }
        }
    }
}
