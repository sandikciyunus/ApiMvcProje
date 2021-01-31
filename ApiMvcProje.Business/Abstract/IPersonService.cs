using ApiMvcProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.Business.Abstract
{
    public interface IPersonService
    {
        IList<Person> GetList();
        void Add(Person person);
    }
}
