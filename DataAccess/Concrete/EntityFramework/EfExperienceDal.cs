using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfExperienceDal : EfRepositoryBase<Experience, Context>, IExperienceDal
    {
    }
}
