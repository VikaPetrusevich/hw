using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.DAL
{
    public class SushiSetRepository<T> : IRepository<T> where T : BaseSushiSet
    {
        private List<T> _collection = new List<T>();

        public void Add(T set)
        {
            _collection.Add(set);
        }

        public T Get(int id)
        {
            return _collection.FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return _collection;
        }
    }
}