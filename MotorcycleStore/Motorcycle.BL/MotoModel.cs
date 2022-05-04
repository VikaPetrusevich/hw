using Motorcycle.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle.BL
{
    public class MotoModel : BaseModel
    {

        public string Name { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Odometer { get; set; }

        public override string ToString()
        {
            return $"\nId: {Id},\n Name: {Name},\n Model: {Model},\n Year: {Year},\n Odometer: {Odometer}.\n";
        }
    }
}
