using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoStore.BL
{
    public interface ICarStoreService
    {
        void AddCar(CarModel carModel);

        CarModel GetCarById(Guid id);

        List<CarModel> GetCarList();

        void DeleteCar(Guid id);

        void UpdateCar(CarModel carModel);
    }
}