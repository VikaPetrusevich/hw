using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle.DAL
{
    public class ListRepository : IRepository<BaseModel>
    {
        private List<BaseModel> _store = new List<BaseModel>();

        public void Add(BaseModel moto)
        {
            _store.Add(moto);
        }

        public void Delete(Guid id)
        {
            for (int i = 0; i < _store.Count; i++)
            {
                if (_store[i].Id == id)
                {
                    _store.RemoveAt(i);
                }
            }
        }

        public List<BaseModel> GetAll()
        {
            return _store;
        }

        public BaseModel GetById(Guid id)
        {
            var moto = _store.First(x=>x.Id==id);
            return moto;
        }
    }
}
