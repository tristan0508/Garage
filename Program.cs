using System;
using System.Collections.Generic;

namespace gary_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
          
            electricVehicles.ForEach(v => Console.WriteLine($"{v.BatteryKWh}"));
          
            electricVehicles.ForEach(v => v.ChargeBattery());
         
            electricVehicles.ForEach(v => Console.WriteLine($"{v.BatteryKWh}"));

        

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };
            Console.WriteLine("");
            Console.WriteLine("Gas Vehicles");
           
            gasVehicles.ForEach(v => Console.WriteLine(v.FuelCapacity));
        
            gasVehicles.ForEach(v => v.RefuelTank());
            
            gasVehicles.ForEach(v => Console.WriteLine(v.FuelCapacity));
        }
    }
}