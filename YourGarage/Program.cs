using System;
using System.Collections.Generic;

namespace YourGarage
{
    class Program
    {       
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var boeing = new Aircraft
            {
                Color = CarColor.Yellow,
                PassengerOccupancy = 100,
                FuelCapacity = 1000
            };

            var jet = new Aircraft
            {
                Color = CarColor.Blue,
                PassengerOccupancy = 10,
                FuelCapacity = 100
            };

            var turboprop = new Aircraft
            {
                Color = CarColor.Purple,
                PassengerOccupancy = 3,
                FuelCapacity = 200
            };

            var aircrafts = new List<Aircraft>();
            aircrafts.Add(boeing);
            aircrafts.Add(jet);
            aircrafts.Add(turboprop);

            foreach (var aircraft in aircrafts)
            {
                aircraft.Flying();
            }
            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()

            var truck = new Car
            {
                Color = CarColor.Red,
                PassengerOccupancy = 6,
                FuelType = "Diesel"
            };

            var bus = new Car
            {
                Color = CarColor.Yellow,
                PassengerOccupancy = 20,
                FuelType = "Diesel"
            };

            var honda = new Car
            {
                Color = CarColor.Purple,
                PassengerOccupancy = 3,
                FuelType = "Unleaded"
            };

            var cars = new List<Car>();
            cars.Add(truck);
            cars.Add(bus);
            cars.Add(honda);

            foreach (var car in cars)
            {
                car.Driving();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()

            var jetSki = new Watercraft
            {
                Color = CarColor.Blue,
                PassengerOccupancy = 2,
                FuelCapacity = 10
            };

            var dinghy = new Watercraft
            {
                Color = CarColor.Gray,
                PassengerOccupancy = 4,
                FuelCapacity = 0
            };

            var watercrafts = new List<Watercraft>();
            watercrafts.Add(jetSki);
            watercrafts.Add(dinghy);

            foreach (var watercraft in watercrafts)
            {
                watercraft.Driving();
            }
        }

    }
}
