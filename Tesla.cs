using System;

namespace gary_garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            BatteryKWh = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla just whispers on by.");
        }


    }
}