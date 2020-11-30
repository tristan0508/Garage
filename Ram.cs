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
            Console.WriteLine($"The {MainColor} Ram speeds on the interstate with an exagerated, \"berrrrrrrrrr!\"");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine("");
        }
        public override void Stop()
        {
            Console.WriteLine("");
        }
    }
}