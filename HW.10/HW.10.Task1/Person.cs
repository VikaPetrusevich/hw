using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task1
{
    internal class Person
    {
        protected int _years;

        public void Say()
        {
            Console.WriteLine("Hello");
        }

        public void SetAge(ref int n)
        {
            _years = n;
        }

    }
}