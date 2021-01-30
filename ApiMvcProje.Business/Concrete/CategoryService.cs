using ApiMvcProje.Business.Abstract;
using ApiMvcProje.DataAccess.Abstract;
using ApiMvcProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMvcProje.Business.Concrete
{
    public class CategoryService:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public IList<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(p => p.Id == id);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
