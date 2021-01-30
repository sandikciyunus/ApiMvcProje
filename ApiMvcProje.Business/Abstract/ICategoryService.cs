using ApiMvcProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.Business.Abstract
{
    public interface ICategoryService
    {
        IList<Category> GetAll();
        Category GetById(int id);
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
