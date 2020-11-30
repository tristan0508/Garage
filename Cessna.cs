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
            Console.WriteLine($"The plane makes a slow, easy {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine("Now that she's in position, the Cessna rolls to a stop.");
        }
    }
}