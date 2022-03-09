using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMessageDal : EfRepositoryBase<Message, Context>, IMessageDal
    {
    }
}
