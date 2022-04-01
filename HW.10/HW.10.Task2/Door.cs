using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task2
{
    public class Door
    {
        private string _color;
        public string Color 
        { 
            get { return _color; } 
            set { _color = value; } 
        }

        public void ShowData() 
        {
            Console.WriteLine($"I am a door, my color is {_color}.");
        }
    }
}