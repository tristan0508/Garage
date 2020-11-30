using System;

namespace gary_garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna screams, \"shoooooo!\"");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine("\"shoooooo!\"");
        }
        public override void Stop()
        {
            Console.WriteLine("\"shoooooo!\"");
        }
    }
}