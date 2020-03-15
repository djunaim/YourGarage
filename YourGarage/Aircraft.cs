using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    class Aircraft :  Vehicle
    {
        public int FuelCapacity { get; set; }
        public void Flying()
        {
            Console.WriteLine($"I am flying a {Color} aircraft and it holds {PassengerOccupancy} people.");
        }
        public void Landing()
        {
            Console.WriteLine("I am landing.");
        }

        public override void Refueling()
        {
            if (FuelCapacity <= 4)
            {
                Console.WriteLine($"You should refuel since you only have  {FuelCapacity} gallons left.");
            }
            else if (FuelCapacity >= 5)
            {
                Console.WriteLine($"You have enough fuel.");
            }
        }
    }
}
