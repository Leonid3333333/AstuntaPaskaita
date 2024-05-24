public class OilFuelCar : Car
{
    public double FuelConsumptionPer100Km { get; set; }

    public OilFuelCar(string make, string model, int year, decimal pricePerDay, double fuelConsumptionPer100Km)
        : base(make, model, year, pricePerDay)
    {
        FuelConsumptionPer100Km = fuelConsumptionPer100Km;
    }

    public override string ToString()
    {
        return base.ToString() + $", Fuel consumption per 100 km: {FuelConsumptionPer100Km}L";
    }
}
