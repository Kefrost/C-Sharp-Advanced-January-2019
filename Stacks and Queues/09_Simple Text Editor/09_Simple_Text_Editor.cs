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
            var n = int.Parse(Console.ReadLine());
            var texts = new Stack<string>();
            var text = "";
            texts.Push(text);
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var cmd = input[0];

                if (cmd == "1")
                {
                    text += input[1];
                    texts.Push(text);
                }

                else if (cmd == "2")
                {
                    var count = int.Parse(input[1]);
                    text = text.Substring(0, text.Length - count);
                    texts.Push(text);
                }
                else if (cmd == "3")
                {
                    var index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (cmd == "4")
                {
                    if (texts.Count >= 2)
                    {
                        texts.Pop();
                        text = texts.Peek();
                    }
                }
            }
        }
    }
}
