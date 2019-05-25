using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var elements = Console.ReadLine().Split();
            int numOfElements = int.Parse(input[0]);
            int numOfElementsToDequeue = int.Parse(input[1]);
            int elementToLook = int.Parse(input[2]);

            var queue = new Queue<int>();

            for (int i = 0; i < elements.Length; i++)
            {
                int current = int.Parse(elements[i]);
                queue.Enqueue(current);
            }

            for (int i = 0; i < numOfElementsToDequeue; i++)
            {
                if (queue.Count != 0)
                {
                    queue.Dequeue();
                }
                else
                {
                    break;
                }

            }
            if (queue.Contains(elementToLook))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int min = queue.Min();
                Console.WriteLine(min);
            }
        }
    }
}
