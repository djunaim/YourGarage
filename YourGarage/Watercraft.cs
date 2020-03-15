using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Watercraft : Vehicle
    {
        public int FuelCapacity { get; set; }
        public void Driving()
        {
            Console.WriteLine($"I'm driving a {Color} water vehicle and it holds {FuelCapacity} gallons of fuel for {PassengerOccupancy} people.");
        }

        public override void Refueling()
        {
            if (FuelCapacity <= 10)
            {
                Console.WriteLine($"Your fuel {FuelCapacity} is below 10. You should refuel.");
            }
        }
    }
}
