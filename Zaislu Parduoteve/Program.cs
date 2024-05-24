using Zaislu_Parduoteve;

public class Program
{


    public static void Main(string[] args)
    {
        {
            // Example usage
            StoreService storeService = new StoreService();

            // Add some toys
            storeService.AddToy(new Constructor("Lego", "LEGO Group", 5, 29.9999, 1000));
            storeService.AddToy(new Puppet("Barbie", "Mattel", 3, 19.9999, HairstyleType.Straight));

           // Remove a toy
           //Toy toyToRemove = storeService.GetAllPuppets(storeService.availableToys).FirstOrDefault();
           // if (toyToRemove != null)
           //     storeService.RemoveToy(toyToRemove);

            // Calculate total cost
            double totalCost = storeService.CalculateTotalCost(1); // Example quantity
            Console.WriteLine($"Total cost for 2 toys: Euro{totalCost}");

            // Write toys to file
            storeService.WriteToysToFile(storeService.availableToys, "toys.txt");

            // Print all items from Constructor
            List<Constructor> constructors = storeService.GetAllConstructors(storeService.availableToys);
            foreach (var constructor in constructors)
            {
                Console.WriteLine($"Constructor: {constructor.Name}, Details: {constructor.DetailCount}");
            }

            // Print all items from Puppet
            List<Puppet> puppets = storeService.GetAllPuppets(storeService.availableToys);
            foreach (var puppet in puppets)
            {
                Console.WriteLine($"Puppet: {puppet.Name}, Hairstyle: {puppet.Hairstyle}");
            }

            // Read all toys from file
            List<Toy> toysFromFile = storeService.ReadToysFromFile("toys.txt");
            foreach (var toy in toysFromFile)
            {
                Console.WriteLine($"Name: {toy.Name}, Manufacturer: {toy.Manufacturer}, Age Limit: {toy.AgeLimit}, Price: {toy.Price}");
            }
        }
    }
}
