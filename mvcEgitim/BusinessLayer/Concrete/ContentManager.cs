using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer1.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal _ContentDal;

        public ContentManager(IContentDal contentDal)
        {
            _ContentDal = contentDal;
        }

        public void ContentAdd(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _ContentDal.List(x => x.HeadingId == id);
        }

        public List<Content> GetListByWriter(int id)
        {
            //Burada daha sonra 4 yerine sessiondan gelen id yi kullancagız.
            return _ContentDal.List(x => x.WriterId == id);
        }
    }
}
