using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task2
{
    public class House
    {
        private int _area;

        private Door _door = new Door();

        public int Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public Door Door
        { 
            get { return _door; }
            set { _door = value; }
        }

        public House(int area, string color)
        {
            _area = area;
            _door.Color = color;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {_area} m2.");
        }

        public void GetDoor()
        {
            Console.WriteLine("Get door.");
        }
   
    }
}