using EntityLayer1.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IContentDal : IRepository<Content>
    {
        void Insert(Contact contact);
        void Update(Contact contact);
        void Delete(Contact contact);
    }
}
