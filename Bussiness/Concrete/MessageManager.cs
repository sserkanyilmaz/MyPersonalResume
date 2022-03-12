using Bussiness.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Bussiness.Concrete
{
    public class MessageManager : IMessageService
    {
        private IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void Add(Message entity)
        {
            _messageDal.Add(entity);
        }

        public void Delete(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public Message Get(int id)
        {
            return _messageDal.Get(x => x.Id == id);

        }

        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }

        public void Update(Message entity)
        {
            _messageDal.Update(entity);
        }
    }
}
