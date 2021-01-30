using ApiMvcProje.DataAccess.Abstract;
using ApiMvcProje.Entities.Concrete;
using Core.DataAccess.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.DataAccess.Concrete
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,AppDbContext>,ICategoryDal
    {
        
    }
}
