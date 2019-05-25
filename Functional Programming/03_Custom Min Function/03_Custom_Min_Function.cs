using System;
using System.Linq;
namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> min = x => x.Min();
            Console.WriteLine(min(input));
        }
    }
}
