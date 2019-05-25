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
            string town = firstInput[3];

            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(name,address,town);
            Console.WriteLine(firstTuple);

            var secondInput = Console.ReadLine().Split();
            string secondName = secondInput[0];
            int liters = int.Parse(secondInput[1]);
            bool isDrunk = secondInput[2].ToLower() == "drunk" ? true : false;

            var secondThreeuple = new Threeuple<string, int, bool>(secondName, liters, isDrunk);
            Console.WriteLine(secondThreeuple);

            var thirdInput = Console.ReadLine().Split();
            string thirdName = thirdInput[0];
            double d = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];

            var thirdThreeuple = new Threeuple<string,double,string>(thirdName,d,bankName);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
