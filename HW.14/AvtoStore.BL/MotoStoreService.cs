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
            if (moto == null) 
            {
                throw new TransportNotFoundException($"Moto with id = {id} don't found.");
            }
            return moto;
        }

        public List<MotoModel> GetMotoList()
        {
            var allMoto = _motoRepository.GetAll();
            return allMoto.Select(x => (MotoModel)x).ToList();
        }

        public void UpdateMoto(MotoModel motoModel)
        {
            bool isDeleted = _motoRepository.Delete(motoModel.Id);
            if (!isDeleted) 
            {
                throw new TransportNotFoundException($"Moto with id = {motoModel.Id} don't deleted.");
            }
            _motoRepository.Add(motoModel);
        }
    }
}