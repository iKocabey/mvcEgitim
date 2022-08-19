using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public  class DraftManager:IDraftService
    {
        IDraftDal _DraftDal;

        public DraftManager(IDraftDal draftDal)
        {
            _DraftDal = draftDal;
        }

        public void DraftAdd(Draft message)
        {
            _DraftDal.Insert(message);
        }

        public void DraftDelete(Draft message)
        {
            throw new NotImplementedException();
        }

        public void DraftUpdate(Draft message)
        {
            throw new NotImplementedException();
        }

        public Draft GetById(int id)
        {
            return _DraftDal.Get(x => x.MessageId == id);
        }

        public List<Draft> GetListDraftBox()
        {
            return _DraftDal.List(x => x.SenderMessage == "admin@gmail.com");
        }
    }
}
