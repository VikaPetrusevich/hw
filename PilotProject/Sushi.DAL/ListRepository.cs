using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.DAL
{
    public class ListRepository<T> : IRepository<T> where T : BaseSushiSet
    {
        private List<T> _collection = new List<T>();

        public void Add(T set)
        {
            _collection.Add(set);
        }

        public List<T> GetAll()
        {
            return _collection;
        }
    }
}