public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal PricePerDay { get; set; }

    public Car(string make, string model, int year, decimal pricePerDay)
    {
        Make = make;
        Model = model;
        Year = year;
        PricePerDay = pricePerDay;
    }

    public override string ToString()
    {
        return $"{Year} {Make} {Model}, Euro{PricePerDay}/day";
    }
}
