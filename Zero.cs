using System;

namespace gary_garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by with a subdued, \"wizzzzzzzz...\"");
        }

        // public override void Turn(string direction)
        // {
        //     Console.WriteLine("");
        // }
        // public override void Stop()
        // {
        //     Console.WriteLine("");
        // }
    }
}