using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoStore.BL
{
    public interface IMotoStoreService
    {
        void AddMoto(MotoModel motoModel);

        MotoModel GetMotoById(Guid id);

        List<MotoModel> GetMotoList();

        void DeleteMoto(Guid id);

        void UpdateMoto(MotoModel motoModel);
    }
}