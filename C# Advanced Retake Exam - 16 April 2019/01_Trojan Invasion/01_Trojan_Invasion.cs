using System;
using System.Linq;
using System.Collections.Generic;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            var won = false;

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Stack<int> warriors = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse);
                    

                if (i % 3 == 0)
                {
                    int extra = int.Parse(Console.ReadLine());
                    plates.Enqueue(extra);
                    
                }

                if (!plates.Any())
                {
                    continue;
                }

                foreach (var item in input)
                {
                    warriors.Push(item);
                }

                while (warriors.Any() && plates.Any())
                {
                    if (warriors.Peek() > plates.Peek())
                    {
                        int value = plates.Dequeue();
                        int warrior = warriors.Pop();
                        warrior -= value;
                        warriors.Push(warrior);
                    }
                    else if (warriors.Peek() < plates.Peek())
                    {
                        int value = warriors.Pop();
                        int plate = plates.Dequeue();
                        plate -= value;

                        plates.Enqueue(plate);

                        for (int p = 0; p < plates.Count - 1; p++)
                        {
                            var tempPlate = plates.Dequeue();
                            plates.Enqueue(tempPlate);
                        }
                    }
                    else
                    {
                        plates.Dequeue();
                        warriors.Pop();
                    }
                }

                if (!plates.Any())
                {
                    won = true;
                }

            }

            if (won)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {String.Join(", ", warriors)}");
            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {String.Join(", ", plates)}");
            }
        }
    }
}
