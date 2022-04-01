using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task2
{
    internal class Person
    {
        private string _name;

        private House _house;

        public Person(string name, House house)
        {
            _name = name;
            _house = house;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am {_name}");
            Console.WriteLine($"Area of my house {_house.Area}.");
            Console.WriteLine($"Door color {_house.Door.Color}");
        }
    }
}