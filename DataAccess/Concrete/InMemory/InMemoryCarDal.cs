using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()//(ctor)  constructor bellekte ref. aldığı zaman çalışıcak blok.
        {
            _cars = new List<Car>
            {
                new Car{BrandId=1,CarId=1,ColorId=1,Description="manuel",Price=200,Stock=2},
                new Car{BrandId=2,CarId=2,ColorId=1,Description="otomatik",Price=200,Stock=2},
                new Car{BrandId=3,CarId=3,ColorId=1,Description="manuel",Price=200,Stock=2},
                new Car{BrandId=1,CarId=4,ColorId=1,Description="otomatik",Price=200,Stock=3},
                new Car{BrandId=2,CarId=5,ColorId=1,Description="manuel",Price=200,Stock=5},
                new Car{BrandId=1,CarId=6,ColorId=1,Description="manuel",Price=200,Stock=4}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)//ref. tipte direk remove ile silemezsin
        {

            //LINQ Language Integrated Query
            //p tek tek dolaşırkenki takma isimi
            //singleOrDefault tek bir tane arar
            Car carToDelet = _cars.SingleOrDefault(p=>p.CarId==car.CarId);
            _cars.Remove(carToDelet);
            
        }

        public void Update(Car car)
        {
            //gönderdiğim ürün ıdsine sahip olan listedeki  ürünü bul demek.
            Car carToUptade = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            
            carToUptade.ColorId = car.ColorId;
            carToUptade.Description = car.Description;
            carToUptade.BrandId = car.BrandId;
            carToUptade.Price = car.Price;
            carToUptade.Stock = car.Stock;

        }

       public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        

        public List<Car> GetAllByBrands(int brandsId)
        {
            //where yeni bir liste haline getirip onu döndürür
           return  _cars.Where(p => p.BrandId == brandsId).ToList();
            
        }

       public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
       
        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        
    }
}
