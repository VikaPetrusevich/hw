using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.BL
{
    public class Order
    {
        public Person PersonInfo { get; set; }

        public List<SushiSet> SushiSet { get; set; }
    }
}
