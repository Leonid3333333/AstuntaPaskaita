using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaislu_Parduoteve
{
    public interface IStoreService
    {
        void AddToy(Toy toy);
        void RemoveToy(Toy toy);
        double CalculateTotalCost(int quantity);
        void WriteToysToFile(List<Toy> toys, string filePath);
        List<Constructor> GetAllConstructors(List<Toy> toys);
        List<Puppet> GetAllPuppets(List<Toy> toys);
        List<Toy> ReadToysFromFile(string filePath);
    }
}
