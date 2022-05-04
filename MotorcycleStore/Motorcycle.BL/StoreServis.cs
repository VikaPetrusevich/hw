using Motorcycle.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle.BL
{
    public class StoreServis : IStoreService
    {
        private IRepository<BaseModel> _repository = new ListRepository();

        public void AddMoto(MotoModel motoModel)
        {
            _repository.Add(motoModel);
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public MotoModel GetMotoById(Guid id)
        {
            MotoModel moto = (MotoModel)_repository.GetById(id);
            return moto;
        }

        public List<MotoModel> GetMotoList()
        {
            var allMoto = _repository.GetAll();
            return allMoto.Select(x=> (MotoModel)x).ToList();
        }

        public void Update(MotoModel motoModel)
        {
            _repository.Delete(motoModel.Id);
            _repository.Add(motoModel);
        }
    }
}
