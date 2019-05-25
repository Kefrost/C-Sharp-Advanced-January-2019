using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int currentRack = capacity;
            var stack = new Stack<int>(clothes);
            
            while (stack.Any())
            {
                int currentClothes = stack.Pop();
                if (currentRack >= currentClothes)
                {
                    currentRack -= currentClothes;
                }
                else
                {
                    currentRack = capacity;
                    currentRack -= currentClothes;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
