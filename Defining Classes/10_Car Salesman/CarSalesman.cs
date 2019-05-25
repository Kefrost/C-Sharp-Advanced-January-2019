
using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class CarSalesman
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int enginesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < enginesCount; i++)
            {
                string[] engineArguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = engineArguments[0];
                int power = int.Parse(engineArguments[1]);
                string displacement = "n/a";
                string efficiency = "n/a";

                Engine engine = new Engine(model, power);

                if (engineArguments.Length == 3)
                {
                    string displacementOrEfficiency = engineArguments[2];
                    if (char.IsDigit(displacementOrEfficiency[0]))
                    {
                        displacement = engineArguments[2];
                    }
                    else
                    {
                        efficiency = engineArguments[2];
                    }
                }
                else if (engineArguments.Length == 4)
                {
                    displacement = engineArguments[2];
                    efficiency = engineArguments[3];
                }

                engine.Displacement = displacement;
                engine.Efficiency = efficiency;

                engines.Add(engine);

            }

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carArguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = carArguments[0];
                string engineModel = carArguments[1];
                string weight = "n/a";
                string color = "n/a";

                Car car = new Car(name, engines.Find(x => x.EngineModel == engineModel));

                if (carArguments.Length == 3)
                {
                    string weightOrColor = carArguments[2];
                    if (char.IsDigit(weightOrColor[0]))
                    {
                        weight = carArguments[2];
                    }
                    else
                    {
                        color = carArguments[2];
                    }
                }
                else if (carArguments.Length == 4)
                {
                    weight = carArguments[2];
                    color = carArguments[3];
                }

                car.Weight = weight;
                car.Color = color;

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
