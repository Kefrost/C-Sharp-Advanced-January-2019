using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var pumps = new Queue<int[]>();
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                pumps.Enqueue(input);
            }
            while (true)
            {
                var totalFuel = 0;
                foreach (var pump in pumps)
                {
                    var fuel = pump[0];
                    var distance = pump[1];
                    totalFuel += fuel - distance;

                    if (totalFuel < 0)
                    {
                        var currentPumps = pumps.Dequeue();
                        pumps.Enqueue(currentPumps);
                        index++;
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
