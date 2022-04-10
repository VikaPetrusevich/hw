using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle.BL
{
    public interface IStoreService
    {
        void AddMoto(MotoModel motoModel);

        MotoModel GetMotoById(Guid id);

        List<MotoModel> GetMotoList();

        void Delete(Guid id);

        void Update(MotoModel motoModel);
    }
}
