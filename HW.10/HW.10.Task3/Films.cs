using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task3
{
    internal class Films : CatalogItem
    {
        public string Director { get; set; }
        public string MainActor { get; set; }
        public string MainActress { get; set; }

        public void Play()
        {
            Console.WriteLine("Film play.");
        }

        public void Play(int number)
        {
            Console.WriteLine("Film play.");
            Console.WriteLine($"Number {number}");
        }

        public void Play(string country)
        {
            Console.WriteLine("Film play.");
            Console.WriteLine($"Country {country}.");
        }
        public void RetrieveInformation()
        {
            Console.WriteLine("\nInformatoin:");
            Console.WriteLine($"Name film: {Name}.");
            Console.WriteLine($"Code film: {Code}.");
            Console.WriteLine($"Film category: {Category}.");
            Console.WriteLine($"Film size: {Size}.");
            Console.WriteLine($"Director: {Director}.");
            Console.WriteLine($"Main actor: {MainActor}.");
            Console.WriteLine($"Main actress: {MainActress}.");
        }
    }
}