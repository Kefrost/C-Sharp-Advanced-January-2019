using System;
using System.Linq;
namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = Console.WriteLine;

            var input = Console.ReadLine().Split().ToList();

            foreach (var item in input)
            {
                print($"Sir {item}");
            }
        }
    }
}
