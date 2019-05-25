using System;
using System.Linq;
using System.Collections.Generic;
namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtForName = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split().ToList();

            Func<string, bool> CheckNames = x => x.Length <= lenghtForName;

            names = names.Where(CheckNames).ToList();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
