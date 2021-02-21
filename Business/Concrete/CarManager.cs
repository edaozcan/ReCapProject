using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //manager göürürseniz anlaki iş katmanın somut sınıfı.
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetAllByBrandsId(int id)
        {
            return _CarDal.GetAll(p => p.CarId == id);
        }

        public List<Car> GetByPrice(int min, int max)
        {
            return _CarDal.GetAll(p => p.Price >= min && p.Price <= max);
        }
    }
}
