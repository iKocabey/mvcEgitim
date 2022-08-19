using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer1.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContentDal : GenericRepository<Content>, IContentDal
    {
        public void Delete(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Insert(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
