using System;

namespace TupleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split();
            string name = firstInput[0] + " " + firstInput[1];
            string address = firstInput[2];

            Tuple<string, string> firstTuple = new Tuple<string, string>(name, address);
            Console.WriteLine(firstTuple);

            var secondInput = Console.ReadLine().Split();
            string secondName = secondInput[0];
            int liters = int.Parse(secondInput[1]);

            var secondTuple = new Tuple<string, int>(secondName, liters);
            Console.WriteLine(secondTuple);

            var thirdInput = Console.ReadLine().Split();
            int integer = int.Parse(thirdInput[0]);
            double d = double.Parse(thirdInput[1]);

            var thirdtTuple = new Tuple<int, double>(integer, d);
            Console.WriteLine(thirdtTuple);
        }
    }
}
