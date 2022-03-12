using Bussiness.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Bussiness.Concrete
{
    public class SkillManager : ISkillService
    {
        private ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }
        public void Add(Skill entity)
        {
            _skillDal.Add(entity);
        }

        public void Delete(Skill entity)
        {
            _skillDal.Delete(entity);
        }

        public Skill Get(int id)
        {
            return _skillDal.Get(x => x.Id == id);
        }

        public List<Skill> GetAll()
        {
            return _skillDal.GetAll();
        }

        public void Update(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}
