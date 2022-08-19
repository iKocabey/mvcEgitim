using DataAccessLayer.Abstract;
using EntityLayer1.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepositories : ICategoryDal
    {
        Content c = new Content();
        DbSet<Category> _object;
        public void delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Delete(Category p)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
            c.SaveChanges();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void update(Category p)
        {
            c.SaveChanges();
        }

        public void Update(Category p)
        {
            throw new NotImplementedException();
        }
    }
}
