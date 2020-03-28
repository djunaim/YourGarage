using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    abstract class Vehicle : IColor, IRefuel
    {
        public CarColor Color => CarColor.Gray;
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
