using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (input[0] == 1)
                {
                    stack.Push(input[1]);
                }
                else if (input[0] == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (input[0] == 3)
                {
                    if (stack.Count != 0)
                    {
                    Console.WriteLine(stack.Max());
                        
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (input[0] == 4)
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Min());

                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.Write($"{stack.Pop()}");

            for (int i = 0; i < stack.Count;)
            {
                int curr = stack.Pop();
                Console.Write($", {curr}");
            }
            Console.WriteLine();
        }
    }
}
