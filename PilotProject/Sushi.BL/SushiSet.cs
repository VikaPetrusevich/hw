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
            return $"Номер суши сета: {Id}; \nНазвание: {Name}; \nОписание: {Description}; \nВес: {Weight}; \nЦена: {Price}.\n";
        }
    }
}