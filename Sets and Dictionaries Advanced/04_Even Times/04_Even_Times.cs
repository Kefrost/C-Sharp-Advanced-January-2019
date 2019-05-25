using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(element))
                {
                    dict.Add(element, 0);
                }
                dict[element]++;
            }
            int result = 0;
            foreach(var item in dict)
            {
                if (item.Value % 2 == 0)
                {
                    result = item.Key;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
