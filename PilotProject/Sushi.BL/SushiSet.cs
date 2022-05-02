using Sushi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.BL
{
    public class SushiSet : BaseSushiSet
    {
        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}; Description: {Description}; Weight: {Weight}; Prace: {Price}.";
        }
    }
}