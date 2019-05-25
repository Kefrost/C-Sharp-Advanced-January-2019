using System;
using System.Collections.Generic;
using System.Linq;

namespace Swap
{
    class Program
    {
        public static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            var box = new Box<double>();
            for (int i = 0; i < linesCount; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }
            //var swapData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //box.Swap(swapData[0], swapData[1]);

            //Console.WriteLine(box);
            var elementToSearch = double.Parse(Console.ReadLine());
            var getCountOfElements = GetCount(box.Data, elementToSearch);
            Console.WriteLine(getCountOfElements);
        }
        public static int GetCount<T>(List<T> list, T element)
            where T : IComparable
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
