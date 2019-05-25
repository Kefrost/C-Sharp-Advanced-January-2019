using System;
using System.Collections.Generic;
using System.Linq;
namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> peoples = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                peoples.Add(person);
            }
            foreach (var item in peoples.OrderBy(x => x.Name).Where(x => x.Age > 30))
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
