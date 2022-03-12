using Bussiness.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Collections.Generic;

namespace Bussiness.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public void Add(Person entity)
        {
            _personDal.Add(entity);
        }

        public void Delete(Person entity)
        {
            _personDal.Delete(entity);
        }

        public Person Get(int id)
        {
            return _personDal.Get(x => x.Id == id);
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public void Update(Person entity)
        {
            _personDal.Update(entity);
        }
    }
}
