namespace gary_garage
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }

        void RefuelTank();
    }
}