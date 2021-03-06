﻿using ApiMvcProje.Entities.Concrete;
using Core.DataAcces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.DataAccess.Abstract
{
    public interface IPersonDal:IEntityRepository<Person>
    {
        IList<Person> SearchPerson(string s);
    }
}
