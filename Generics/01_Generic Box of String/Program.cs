using System;

namespace GenericBoxofString
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var box = new Box<string>();

                box.Value = input;
                Console.WriteLine($"{box.Value.GetType()}{box.ToString()}");
            }
        }
    }
}
