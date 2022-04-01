using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task3
{
    internal class ComputerPrograms : CatalogItem 
    {
        public void RetrieveInformation()
        {
            Console.WriteLine("\nInformatoin:");
            Console.WriteLine($"Name computer program: {Name}.");
            Console.WriteLine($"Code computer program: {Code}.");
            Console.WriteLine($"Computer program category: {Category}.");
            Console.WriteLine($"Computer program size: {Size}.");
        }
    }
}