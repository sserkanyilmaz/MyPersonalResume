using Bussiness.Abstract;
using DataAccess.Abstract;
using Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course entity)
        {
            _courseDal.Add(entity);
        }

        public void Delete(Course entity)
        {
            _courseDal.Delete(entity);
        }

        public Course Get(int id)
        {
            return _courseDal.Get(x => x.Id == id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course entity)
        {
            _courseDal.Update(entity);

        }
        
    }
}
