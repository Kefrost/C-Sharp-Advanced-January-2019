using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FstFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAvailable = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isComplete = true;
            var queue = new Queue<int>();
            for (int i = 0; i < orders.Length; i++)
            {
                queue.Enqueue(orders[i]);
            }
            int max = queue.Max();
            while (true)
            {
                if (queue.Count != 0)
                {
                    if (queue.Peek() <= foodAvailable)
                    {
                        int current = queue.Dequeue();
                        foodAvailable -= current;
                    }
                    else
                    {
                        isComplete = false;
                        break;
                    }
                }
                if (queue.Count == 0)
                {
                    break;
                }
                if (foodAvailable <= 0)
                {
                    isComplete = false;
                    break;
                }
                
            }
            if (isComplete == false)
            {
                Console.WriteLine(max);
                Console.Write($"Orders left: ");
                for (int i = 0; i < queue.Count;)
                {
                    Console.Write($"{queue.Dequeue()} ");
                }
            }
            else
            {
                Console.WriteLine(max);
                Console.WriteLine("Orders complete");
            }
            Console.WriteLine();
        }
    }
}
