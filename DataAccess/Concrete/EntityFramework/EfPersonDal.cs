using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : EfRepositoryBase<Person, Context>, IPersonDal
    {
    }
}
