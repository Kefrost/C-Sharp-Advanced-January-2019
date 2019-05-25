using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var elements = Console.ReadLine().Split();
            int numOfElements = int.Parse(input[0]);
            int numOfElementsToPop = int.Parse(input[1]);
            int elementToLook = int.Parse(input[2]);

            var stack = new Stack<int>();

            for (int i = 0; i < numOfElements; i++)
            {
                int num = int.Parse(elements[i]);
                stack.Push(num);
            }

            for (int i = 1; i <= numOfElementsToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(elementToLook))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int min = stack.Pop();
                for (int i = 0; i < stack.Count; i++)
                {
                    int current = stack.Pop();
                    if (current < min)
                    {
                        min = current;
                    }
                }
                Console.WriteLine(min);
            }
        }
    }
}
