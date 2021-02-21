using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

       List<Car> GetAllByBrandsId(int id);

       List<Car> GetByPrice(int min, int max);
    }
}
