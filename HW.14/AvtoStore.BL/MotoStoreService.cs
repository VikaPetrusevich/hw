using AvtoStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoStore.BL
{
    public class MotoStoreService : IMotoStoreService
    {
        private IRepository<MotoModel> _motoRepository = new ListRepository<MotoModel>();

        public void AddMoto(MotoModel motoModel)
        {
            _motoRepository.Add(motoModel);
        }

        public void DeleteMoto(Guid id)
        {
            _motoRepository.Delete(id);
        }

        public MotoModel GetMotoById(Guid id)
        {
            MotoModel moto = _motoRepository.GetById(id);
            return moto;
        }

        public List<MotoModel> GetMotoList()
        {
            var allMoto = _motoRepository.GetAll();
            return allMoto.Select(x => (MotoModel)x).ToList();
        }

        public void UpdateMoto(MotoModel motoModel)
        {
            _motoRepository.Delete(motoModel.Id);
            _motoRepository.Add(motoModel);
        }
    }
}