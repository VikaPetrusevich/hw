using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoStore.DAL
{
    public class ListRepository<T> : IRepository<T> where T : BaseVehicleModel
    {
        private List<T> _store = new List<T>();

        public void Add(T vehicleModel)
        {
            _store.Add(vehicleModel);
        }

        public bool Delete(Guid id)
        {
            bool isDeleted = false;
            for (int i = 0; i < _store.Count; i++)
            {
                if (_store[i].Id == id)
                {
                    _store.RemoveAt(i);
                    isDeleted = true;
                }
            }
            return isDeleted;
        }

        public List<T> GetAll()
        {
            return _store;
        }

        public T GetById(Guid id)
        {
            var vehicleModel = _store.FirstOrDefault(x => x.Id == id);
            return vehicleModel;
        }
    }
}