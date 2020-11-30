using System;

namespace gary_garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine("\"berrrrrrrrrr!\"");
        }
    }
}