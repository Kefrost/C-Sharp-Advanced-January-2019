namespace _05._Count_Symbols
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<char, int> listOfLetters = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                if (!listOfLetters.ContainsKey(letter))
                {
                    listOfLetters[letter] = 0;
                }

                listOfLetters[letter]++;
            }

            foreach (var letter in listOfLetters.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
