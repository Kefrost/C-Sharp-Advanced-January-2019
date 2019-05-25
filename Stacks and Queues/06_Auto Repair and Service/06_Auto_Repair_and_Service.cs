using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carService
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = Console.ReadLine().Split().ToArray();
            string[] input = Console.ReadLine().Split('-').ToArray();
            var carsQueue = new Queue<string>(cars);
            var served = new List<string>();
            while (input[0] != "End")
            {
                if (input[0] == "Service")
                {
                    if (carsQueue.Any())
                    {
                        string car = carsQueue.Dequeue();
                        served.Add(car);
                        Console.WriteLine($"Vehicle {car} got served.");
                    }
                }
                else if (input[0] == "CarInfo")
                {
                    if (served.Contains(input[1]))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
                else if (input[0] == "History")
                {
                    served.Reverse();
                    Console.Write(served.First());
                    for (int i = 1; i < served.Count; i++)
                    {
                        Console.Write($", {served[i]}");
                    }
                    served.Reverse();
                    Console.WriteLine();
                }
                input = Console.ReadLine().Split('-').ToArray();
            }

            if (carsQueue.Any())
            {
                Console.Write($"Vehicles for service: {carsQueue.Dequeue()}");
                for (int i = 0; i < carsQueue.Count;)
                {
                    Console.Write($", {carsQueue.Dequeue()}");
                }
                Console.WriteLine();
            }
            served.Reverse();
            Console.Write($"Served vehicles: {served.First()}");
            for (int i = 1; i < served.Count; i++)
            {
                Console.Write($", {served[i]}");
            }
            Console.WriteLine();
        }
    }
}
