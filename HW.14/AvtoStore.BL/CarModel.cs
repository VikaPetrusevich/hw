using AvtoStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoStore.BL
{
    public class CarModel : BaseVehicleModel
    {
        public override string ToString()
        {
            return $"\nId: {Id},\n Name: {Name},\n Model: {Model},\n Year: {Year},\n Odometer: {Odometer}.\n";
        }
    }
}