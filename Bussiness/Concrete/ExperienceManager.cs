using Bussiness.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Bussiness.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        private IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }
        public void Add(Experience entity)
        {
            _experienceDal.Add(entity);
        }

        public void Delete(Experience entity)
        {
            _experienceDal.Delete(entity);
        }

        public Experience Get(int id)
        {
            return _experienceDal.Get(x => x.Id == id);
        }

        public List<Experience> GetAll()
        {
            return _experienceDal.GetAll();
        }

        public void Update(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
