using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEducationDal : EfRepositoryBase<Education, Context>, IEducationDal
    {
    }
}
