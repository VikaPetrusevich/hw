using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task3
{
    internal class MusicFiles : CatalogItem
    {
        public string Singer { get; set; }
        public int Lenght { get; set; }

        public void Play()
        {
            Console.WriteLine("Music play.");
        }

        public void Play(int number)
        {
            Console.WriteLine("Music play.");
            Console.WriteLine($"Number {number}");
        }

        public void Play(string country)
        {
            Console.WriteLine("Music play.");
            Console.WriteLine($"Country {country}.");
        }
        public void RetrieveInformation()
        {
            Console.WriteLine("\nInformatoin:");
            Console.WriteLine($"Name song: {Name}.");
            Console.WriteLine($"Code song: {Code}.");
            Console.WriteLine($"Music category: {Category}.");
            Console.WriteLine($"Song size: {Size}.");
            Console.WriteLine($"Singer: {Singer}.");
            Console.WriteLine($"Song lenght: {Lenght} in seconds.");
        }
    }
}