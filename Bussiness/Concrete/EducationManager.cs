using Bussiness.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EducationManager : IEducationService
    {
        private IEducationDal _educationDal;
        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }
        public void Add(Education entity)
        {
            _educationDal.Add(entity);
        }

        public void Delete(Education entity)
        {
            _educationDal.Delete(entity);
        }

        public Education Get(int id)
        {
            return _educationDal.Get(x => x.Id == id);
        }

        public List<Education> GetAll()
        {
            return _educationDal.GetAll();
        }

        public void Update(Education entity)
        {
            _educationDal.Update(entity);
        }
    }
}
