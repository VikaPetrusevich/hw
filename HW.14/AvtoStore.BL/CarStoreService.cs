using AvtoStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoStore.BL
{
    public class CarStoreService : ICarStoreService
    {
        private IRepository<CarModel> _carRepository = new ListRepository<CarModel>();
        
        public void AddCar(CarModel carModel)
        {
            _carRepository.Add(carModel);
        }

        public void DeleteCar(Guid id)
        {
            _carRepository.Delete(id);
        }

        public CarModel GetCarById(Guid id)
        {
            CarModel car = _carRepository.GetById(id);
            return car;
        }

        public List<CarModel> GetCarList()
        {
            var allCars = _carRepository.GetAll();
            return allCars.Select(x => (CarModel)x).ToList();
        }

        public void UpdateCar(CarModel carModel)
        {
            _carRepository.Delete(carModel.Id);
            _carRepository.Add(carModel);
        }
    }
}