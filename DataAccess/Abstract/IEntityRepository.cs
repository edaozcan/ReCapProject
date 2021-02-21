using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint:kısıtlama
    //class:ref. tip olabilir
    //IEntity :IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new():newlene olabilir
    public interface IEntityRepository<T> 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T,bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        


    }
}
