namespace _06._Wardrobe
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> listOfClothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < number; i++)
            {
                string[] line = Console.ReadLine().Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = line[0];

                if (!listOfClothes.ContainsKey(color))
                {
                    listOfClothes[color] = new Dictionary<string, int>();
                }

                for (int j = 1; j < line.Length; j++)
                {
                    string cloth = line[j];
                    if (!listOfClothes[color].ContainsKey(cloth))
                    {
                        listOfClothes[color][cloth] = 0;
                    }

                    listOfClothes[color][cloth]++;
                }
            }

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colors = input[0];
            string clothes = input[1];

            foreach (var kvp in listOfClothes)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var item in kvp.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");
                    if (kvp.Key == colors && item.Key == clothes)
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
