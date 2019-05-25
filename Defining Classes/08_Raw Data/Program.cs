using System;
using System.Collections.Generic;
using System.Linq;
namespace RawData
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
                int engineSpeed = int.Parse(carTokens[1]);
                int enginePower = int.Parse(carTokens[2]);
                int cargoWeight = int.Parse(carTokens[3]);
                string cargoType = carTokens[4];
                double firstTirePressure = double.Parse(carTokens[5]);
                int firstTireAge = int.Parse(carTokens[6]);
                double secondTirePressure = double.Parse(carTokens[7]);
                int secondTireAge = int.Parse(carTokens[8]);
                double thirdTirePressure = double.Parse(carTokens[9]);
                int thirdTireAge = int.Parse(carTokens[10]);
                double fourthTirePressure = double.Parse(carTokens[11]);
                int fourthTireAge = int.Parse(carTokens[12]);

                Engine engine = new Engine(engineSpeed, enginePower);

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire firstTire = new Tire(firstTirePressure, firstTireAge);

                Tire secondTire = new Tire(secondTirePressure, secondTireAge);

                Tire thirdTire = new Tire(thirdTirePressure, thirdTireAge);

                Tire fourthTire = new Tire(fourthTirePressure, fourthTireAge);

                Tire[] tireSet = new Tire[]
                {
                    firstTire,
                    secondTire,
                    thirdTire,
                    fourthTire
                };

                Car car = new Car(model, engine, cargo, tireSet);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(x => x.CarCargo.CargoType == "fragile"
                && x.CarTires.Any(y => y.TirePressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(x => x.CarCargo.CargoType == "flamable"
                && x.CarEngine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
