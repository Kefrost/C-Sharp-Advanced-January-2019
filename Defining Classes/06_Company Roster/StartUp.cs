using System;
using System.Linq;
using System.Collections.Generic;
namespace CompanyRoster
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            List<Employee> employes = new List<Employee>();

            int inputLinesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLinesCount; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                decimal salary = decimal.Parse(tokens[1]);
                string position = tokens[2];
                string deparment = tokens[3];

                Employee employee = new Employee(name, salary, position, deparment);

                if (tokens.Length > 4)
                {
                    if (tokens.Length == 5)
                    {
                        if (tokens[4].Contains("@"))
                        {
                            employee.Email = tokens[4];
                        }
                        else
                        {
                            employee.Age = int.Parse(tokens[4]);
                        }
                    }
                    else
                    {
                        employee.Email = tokens[4];
                        employee.Age = int.Parse(tokens[5]);
                    }
                }

                employes.Add(employee);
            }

            string bestDepartment = employes
                .GroupBy(x => x.Department)
                .OrderByDescending(y => y.Select(s => s.Salary)
                .Average())
                .FirstOrDefault()
                .Key;

            Console.WriteLine($"Highest Average Salary: {bestDepartment}");

            foreach (var employee in employes.Where(x => x.Department == bestDepartment).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
