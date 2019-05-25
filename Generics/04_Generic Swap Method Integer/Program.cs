using System;
using System.Linq;

namespace Swap
{
    class Program
    {
        public static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            var box = new Box<int>();
            for (int i = 0; i < linesCount; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Add(input);
            }
            var swapData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(swapData[0], swapData[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
