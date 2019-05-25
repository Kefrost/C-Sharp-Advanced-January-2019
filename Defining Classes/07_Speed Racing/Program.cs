using System;
using System.Collections.Generic;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carTokens[0];
                double fuelAmount = double.Parse(carTokens[1]);
                double fuelConsumptionPerKm = double.Parse(carTokens[2]);

                Car car = new Car()
                {
                    Model = model,
                    FuelAmount = fuelAmount,
                    FuelConsumption = fuelConsumptionPerKm
                };

                cars.Add(car);
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] driveTokens = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string askedCarModel = driveTokens[1];
                double distanceToTravel = double.Parse(driveTokens[2]);

                cars.Find(x => x.Model == askedCarModel).CheckDistance(distanceToTravel);

                inputLine = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }
}
