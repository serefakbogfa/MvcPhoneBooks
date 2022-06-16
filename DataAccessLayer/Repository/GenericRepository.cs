using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepositoryy<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepositoryy()
        {
            _object = c.Set<T>();
        }

        public void Add(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;         
            c.SaveChanges();
        }

        public void Delete(T p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> GetAll()
        {
            
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> Filter)
        {
            return _object.Where(Filter).ToList();
        }



        public void Update(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    
    }
}
