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
    public class MessageManager : IMessageService
    {
        IMessageDal _MessageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _MessageDal = messageDal;
        }

        public Message GetById(int id)
        {
            return _MessageDal.Get(x => x.MessageId == id);
        }

      

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageAdd(Message message)
        {
            _MessageDal.Insert(message);
        }

        public List<Message> GetListInBox(string p)
        {
            return _MessageDal.List(x => x.ReceiverMessage == p);
        }

        public List<Message> GetListSendBox(string p)
        {
            return _MessageDal.List(x => x.SenderMessage == p);
        }
    }
}
