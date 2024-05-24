using System;

class Program
{
    static void Main()
    {
        Rent rent = new Rent();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Car Rental System Menu:");
            Console.WriteLine("1. Add new car");
            Console.WriteLine("2. Pick up a car to remove");
            Console.WriteLine("3. Calculate rental price");
            Console.WriteLine("4. Print fleet");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewCar(rent);
                    break;
                case "2":
                    PickUpCar(rent);
                    break;
                case "3":
                    CalculateRentalPrice(rent);
                    break;
                case "4":
                    rent.PrintFleet();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddNewCar(Rent rent)
    {
        Console.Write("Enter car type (1: OilFuelCar, 2: ElectricCar): ");
        string carType = Console.ReadLine();
        Console.Write("Enter make: ");
        string make = Console.ReadLine();
        Console.Write("Enter model: ");
        string model = Console.ReadLine();
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter price per day: ");
        decimal pricePerDay = decimal.Parse(Console.ReadLine());

        if (carType == "1")
        {
            Console.Write("Enter fuel consumption per 100 km: ");
            double fuelConsumption = double.Parse(Console.ReadLine());
            OilFuelCar car = new OilFuelCar(make, model, year, pricePerDay, fuelConsumption);
            rent.AddCar(car);
        }
        else if (carType == "2")
        {
            Console.Write("Enter battery charging time: ");
            double chargingTime = double.Parse(Console.ReadLine());
            ElectricCar car = new ElectricCar(make, model, year, pricePerDay, chargingTime);
            rent.AddCar(car);
        }
        else
        {
            Console.WriteLine("Invalid car type.");
        }
    }

    static void PickUpCar(Rent rent)
    {
        rent.PrintFleet();
        Console.Write("Enter the index of the car to pick up: ");
        int index = int.Parse(Console.ReadLine());
        Car car = rent.PickUpCar(index);
        if (car != null)
        {
            Console.WriteLine($"You picked up: {car}");
        }
    }

    static void CalculateRentalPrice(Rent rent)
    {
        rent.PrintFleet();
        Console.Write("Enter the index of the car: ");
        int index = int.Parse(Console.ReadLine());
        if (index >= 0 && index < rent.AvailableCars.Count)
        {
            Car car = rent.AvailableCars[index];
            Console.Write("Enter the number of days to rent: ");
            int days = int.Parse(Console.ReadLine());
            decimal price = rent.CalculateRentalPrice(car, days);
            Console.WriteLine($"The total rental price for {days} days is: Euro{price}");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }
}
