using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.DAL
{
    public class BaseSushiSet
    {
        public string Name { get; set; }

        public string Description { get; set; }
        
        public int Weight { get; set; }

        public decimal Prace { get; set; }
    }
}