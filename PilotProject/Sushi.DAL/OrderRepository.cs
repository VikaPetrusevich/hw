using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi.DAL
{
    public class OrderRepository<T> : IRepository<T> where T : BaseOrder
    {
        private List<T> _collection = new List<T>();

        public void Add(T order)
        {
            _collection.Add(order);
        }

        public T Get(int id)
        {
            return _collection.FirstOrDefault(x => x.Id == id);
        }

        List<T> IRepository<T>.GetAll()
        {
            return _collection;
        }
    }
}
