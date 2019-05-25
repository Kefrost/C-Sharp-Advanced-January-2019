using System;
using System.Collections.Generic;

namespace Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var username = Console.ReadLine();
                set.Add(username);
            }
            foreach (var username in set)
            {
                Console.WriteLine(username);
            }
        }
    }
}
