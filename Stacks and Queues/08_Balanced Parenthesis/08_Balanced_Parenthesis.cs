using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var parenthesis = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    parenthesis.Push(input[i]);
                }
                else
                {
                    if (parenthesis.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    if (input[i] == ')')
                    {
                        var lastParentheses = parenthesis.Pop();

                        if (lastParentheses != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (input[i] == ']')
                    {
                        var lastParentheses = parenthesis.Pop();

                        if (lastParentheses != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    if (input[i] == '}')
                    {
                        var lastParentheses = parenthesis.Pop();

                        if (lastParentheses != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
            }

            if (parenthesis.Count == 0)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
