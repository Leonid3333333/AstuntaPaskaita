public class ElectricCar : Car
{
    public double BatteryChargingTime { get; set; }

    public ElectricCar(string make, string model, int year, decimal pricePerDay, double batteryChargingTime)
        : base(make, model, year, pricePerDay)
    {
        BatteryChargingTime = batteryChargingTime;
    }

    public override string ToString()
    {
        return base.ToString() + $", Battery charging time: {BatteryChargingTime} hours";
    }
}
