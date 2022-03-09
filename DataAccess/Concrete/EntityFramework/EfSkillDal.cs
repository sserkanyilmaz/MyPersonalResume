using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSkillDal : EfRepositoryBase<Skill, Context>, ISkillDal
    {
    }
}
