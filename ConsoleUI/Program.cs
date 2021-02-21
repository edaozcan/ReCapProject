using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetByPrice(200, 300);
            foreach (var car in result)
            {
                Console.WriteLine(car.ColorId);
            }

        }    
    }
}
