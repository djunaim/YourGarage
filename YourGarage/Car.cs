using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Car : Vehicle
    {
        public string FuelType { get; set; }
        public void Driving()
        {
            Console.WriteLine($"I'm driving a {Color} vehicle and it holds {PassengerOccupancy}. The fuel type of this vehicle is {FuelType}.");
        }
        public void Braking()
        {
            Console.WriteLine("I'm braking.");
        }
        public override void Refueling()
        {
            if (PassengerOccupancy >= 4)
            {
                Console.WriteLine($"You should think about refueling soon since you have {PassengerOccupancy} people in your car and it's heavy.");
            }
        }
    }
}
