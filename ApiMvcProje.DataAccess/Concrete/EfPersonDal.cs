using ApiMvcProje.DataAccess.Abstract;
using ApiMvcProje.Entities.Concrete;
using Core.DataAccess.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiMvcProje.DataAccess.Concrete
{
    public class EfPersonDal : EfEntityRepositoryBase<Person, AppDbContext>, IPersonDal
    {
        public IList<Person> SearchPerson(string s)
        {
            using(var context=new AppDbContext())
            {
                var sonuc = from p in context.Persons
                            where p.Name.Contains(s)
                            select p;

                return sonuc.ToList();
            }
        }
    }
}
