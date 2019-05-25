namespace _02.Collection
{
    using System;
    using System.Linq;


    public class StartUp
        {
            public static void Main()
            {
                var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                var numbers = new Lake(input);

                Console.WriteLine(string.Join(", ", numbers));
            }


        }
    }
