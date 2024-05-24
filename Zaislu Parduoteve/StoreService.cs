using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaislu_Parduoteve
{
    public class StoreService : IStoreService
    {
        public List<Toy> availableToys;

        public StoreService()
        {
            availableToys = new List<Toy>();
        }

        public void AddToy(Toy toy)
        {
            availableToys.Add(toy);
        }

        public void RemoveToy(Toy toy)
        {
            availableToys.Remove(toy);
        }

        public double CalculateTotalCost(int quantity)
        {
            return availableToys.Sum(toy => toy.Price * quantity);
        }

        public void WriteToysToFile(List<Toy> toys, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (Toy toy in toys)
                {
                    sw.WriteLine($"{toy.Name},{toy.Manufacturer},{toy.AgeLimit},{toy.Price}");
                }
            }
        }

        public List<Constructor> GetAllConstructors(List<Toy> toys)
        {
            return toys.OfType<Constructor>().ToList();
        }

        public List<Puppet> GetAllPuppets(List<Toy> toys)
        {
            return toys.OfType<Puppet>().ToList();
        }

        public List<Toy> ReadToysFromFile(string filePath)
        {
            List<Toy> toys = new List<Toy>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string name = parts[0];
                    string manufacturer = parts[1];
                    int ageLimit = int.Parse(parts[2]);
                    double price = double.Parse(parts[3]);

                    // Assuming the type of toy is indicated in the file
                    // For example: Constructor,Puzzle,6,25.99
                    switch (parts[0])
                    {
                        case "Constructor":
                            int detailCount = int.Parse(parts[4]);
                            toys.Add(new Constructor(name, manufacturer, ageLimit, price, detailCount));
                            break;
                        case "Puppet":
                            HairstyleType hairstyle = (HairstyleType)Enum.Parse(typeof(HairstyleType), parts[4]);
                            toys.Add(new Puppet(name, manufacturer, ageLimit, price, hairstyle));
                            break;
                            // Add other toy types if needed
                    }
                }
            }

            return toys;
        }
    }
}
