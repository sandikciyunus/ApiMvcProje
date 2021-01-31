using ApiMvcProje.Business.Abstract;
using ApiMvcProje.DataAccess.Abstract;
using ApiMvcProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.Business.Concrete
{
    public class PersonService : IPersonService
    {
        private IPersonDal _personDal;
        public PersonService(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public void Add(Person person)
        {
            _personDal.Add(person);
        }

        public IList<Person> GetList()
        {
            return _personDal.GetList();
        }
    }
}
