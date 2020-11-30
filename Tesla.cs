using System;

namespace gary_garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla just whispers on by.");
        }


    }
}