using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    abstract class Vehicle
    {
        public CarColor Color { get; set; }
        public int PassengerOccupancy { get; set; }
        public abstract void Refueling();
    }
    enum CarColor
    {
        Yellow,
        Blue,
        Red,
        Purple,
        Gray
    }
}
