using Sushi.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.BL
{
    public class Order:BaseOrder
    {
        public Person PersonInfo { get; set; } = new Person();

        public List<SushiSet> SushiSet { get; set; } = new List<SushiSet>();
    }
}
