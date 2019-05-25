using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace stackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> leftSocks = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            Queue<int> rightSocks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            List<int> pairs = new List<int>();
            while (leftSocks.Any() && rightSocks.Any())
            {
                if (leftSocks.Peek() < rightSocks.Peek())
                {
                    leftSocks.Pop();
                }
                else if (leftSocks.Peek() == rightSocks.Peek())
                {
                    rightSocks.Dequeue();
                    var current = leftSocks.Pop();
                    current++;
                    leftSocks.Push(current);
                }
                else
                {
                    var pair = leftSocks.Pop() + rightSocks.Dequeue();

                    pairs.Add(pair);
                }
                
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}
