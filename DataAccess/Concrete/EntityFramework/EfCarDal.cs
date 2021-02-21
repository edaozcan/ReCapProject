using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCarDal : ICarDal
    {
       
        public void Add(Car entity)
        {
            //IDisposable pattern implementation of c#
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var addedEntity=context.Entry(entity);//ref. yakala
                addedEntity.State = EntityState.Added;//o aslında eklenecek nesne
                context.SaveChanges();//ekle
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var deletedEntity = context.Entry(entity);//ref. yakala
                deletedEntity.State = EntityState.Deleted;//o aslında eklenecek nesne
                context.SaveChanges();//ekle
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                return filter == null 
                    ? context.Set<Car>().ToList() 
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var updatedEntity = context.Entry(entity);//ref. yakala
                updatedEntity.State = EntityState.Modified;//o aslında güncel. nesne
                context.SaveChanges();//gün
            }
        }
    }
}
