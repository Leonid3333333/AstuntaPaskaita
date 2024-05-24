using System;
using System.Collections.Generic;

public class Rent
{
    public List<Car> AvailableCars { get; set; }

    public Rent()
    {
        AvailableCars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        AvailableCars.Add(car);
        Console.WriteLine("Car added successfully.");
    }

    public Car PickUpCar(int index)
    {
        if (index >= 0 && index < AvailableCars.Count)
        {
            Car car = AvailableCars[index];
            AvailableCars.RemoveAt(index);
            Console.WriteLine("Car picked up successfully.");
            return car;
        }
        else
        {
            Console.WriteLine("Invalid index.");
            return null;
        }
    }

    public decimal CalculateRentalPrice(Car car, int numberOfDays)
    {
        return car.PricePerDay * numberOfDays;
    }

    public void PrintFleet()
    {
        for (int i = 0; i < AvailableCars.Count; i++)
        {
            Console.WriteLine($"{i}: {AvailableCars[i]}");
        }
    }
}
