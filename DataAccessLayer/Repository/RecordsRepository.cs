using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class RecordsRepository : IRecordsDal
    {
        Context c = new Context();
        DbSet<Records> _object;

        public void Add(Records p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public void Delete(Records p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Records Get(Expression<Func<Records, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Records> GetAll()
        {
            return _object.ToList();
        }

        public List<Records> List(Expression<Func<Records, bool>> Filter)
        {
            return _object.Where(Filter).ToList();
        }

        public void Update(Records p)
        {
            c.SaveChanges();
        }
    }
}
